namespace OutlandArea.Common.Geometry;

public class AstrodynamicalMetrics
{
    float Direction { get; set; }
    double Velocity { get; set; }
    double Acceleration { get; set; }
    ISpacePoint Location { get; set; }
}
