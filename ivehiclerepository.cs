'''
This interface defines the contract for a vehicle repository.
'''
public interface IVehicleRepository
{
    void Insert(Vehicle vehicle);
    void Update(Vehicle vehicle);
    Vehicle Get(Guid id);
    void Delete(Guid id);
    void UpdateProperties(Guid id, string name, string brand, int year);
}