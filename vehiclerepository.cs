'''
This class implements the IVehicleRepository interface and provides the functionality to insert, update, get, and delete vehicles.
'''
public class VehicleRepository : IVehicleRepository
{
    private Dictionary<Guid, Vehicle> _vehicles;
    public VehicleRepository()
    {
        _vehicles = new Dictionary<Guid, Vehicle>();
    }
    public void Insert(Vehicle vehicle)
    {
        _vehicles.Add(vehicle.Id, vehicle);
    }
    public void Update(Vehicle vehicle)
    {
        if (_vehicles.ContainsKey(vehicle.Id))
        {
            _vehicles[vehicle.Id] = vehicle;
        }
    }
    public Vehicle Get(Guid id)
    {
        if (_vehicles.ContainsKey(id))
        {
            return _vehicles[id];
        }
        return null;
    }
    public void Delete(Guid id)
    {
        if (_vehicles.ContainsKey(id))
        {
            _vehicles.Remove(id);
        }
    }
    public void UpdateProperties(Guid id, string name, string brand, int year)
    {
        if (_vehicles.ContainsKey(id))
        {
            var vehicle = _vehicles[id];
            vehicle.Name = name;
            vehicle.Brand = brand;
            vehicle.Year = year;
        }
    }
}