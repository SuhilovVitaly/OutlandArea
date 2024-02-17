namespace OutlandArea.Interfaces.Universe.Equipment.StationWarehouse;

public interface IWarehouse
{
    long Id { get; set; }
    long OwnerId { get; set; }
    long CelestialObjectId { get; set; }
    ICapacity Capacity { get; set; }
}
