namespace OutlandArea.Interfaces.Measurement;

public interface IPhysicalMetrics
{
    long Id { get; set; }
    EntityType Type { get; set; }
    float Volume { get; set; }
}
