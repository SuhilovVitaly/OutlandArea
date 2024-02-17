namespace OutlandArea.Interfaces.Measurement;

public interface IAstrodynamicalMetrics
{
    float Direction { get; set; }
    double Velocity { get; set; }
    double Acceleration { get; set; }
    ISpacePoint Location { get; set; }
}
