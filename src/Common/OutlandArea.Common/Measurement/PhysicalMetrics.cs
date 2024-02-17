namespace OutlandArea.Common.Geometry;

public class PhysicalMetrics: IPhysicalMetrics
{
    public long Id { get; set; }
    public EntityType Type { get; set; }
    public float Volume { get; set; }
}
