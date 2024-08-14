using Microsoft.AspNetCore.Mvc;
[Route("api/vehicles")]
[ApiController]
public class VehicleApi : ControllerBase
{
    private IVehicleRepository _vehicleRepository;
    public VehicleApi(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }
    /// <summary>
    /// Inserts a new vehicle into the repository.
    /// </summary>
    [HttpPost]
    public IActionResult Insert([FromBody] Vehicle vehicle)
    {
        _vehicleRepository.Insert(vehicle);
        return Ok();
    }
    /// <summary>
    /// Updates an existing vehicle in the repository.
    /// </summary>
    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] Vehicle vehicle)
    {
        var existingVehicle = _vehicleRepository.Get(id);
        if (existingVehicle == null)
        {
            return NotFound();
        }
        _vehicleRepository.UpdateProperties(id, vehicle.Name, vehicle.Brand, vehicle.Year);
        return Ok();
    }
    /// <summary>
    /// Retrieves a vehicle from the repository based on its ID.
    /// </summary>
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var vehicle = _vehicleRepository.Get(id);
        if (vehicle == null)
        {
            return NotFound();
        }
        return Ok(vehicle);
    }
    /// <summary>
    /// Deletes a vehicle from the repository based on its ID.
    /// </summary>
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var vehicle = _vehicleRepository.Get(id);
        if (vehicle == null)
        {
            return NotFound();
        }
        _vehicleRepository.Delete(id);
        return Ok();
    }
}