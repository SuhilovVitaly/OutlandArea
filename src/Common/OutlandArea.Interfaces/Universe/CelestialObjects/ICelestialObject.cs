namespace OutlandArea.Interfaces.Universe.CelestialObjects;

public interface ICelestialObject
{
    long Id { get; set; }
    string Name { get; set; }
    IAstrodynamicalMetrics AstrodynamicalMetrics { get; set; }
    CelestialObjectTypes Type { get; set; }
}
