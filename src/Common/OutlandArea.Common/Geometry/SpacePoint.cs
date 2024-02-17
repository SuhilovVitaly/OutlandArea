using System.Diagnostics;

namespace OutlandArea.Common.Geometry;

[DebuggerDisplay("{X} : {Y}")]
[Serializable]
public class SpacePoint: ISpacePoint
{
    public SpacePoint(float x, float y) => (X, Y) = (x, y);

    public float X { get; set; }
    public float Y { get; set; }

    public override bool Equals(object obj)
    {
        return obj is SpacePoint otherPoint && this == otherPoint;
    }

    public static bool operator == (SpacePoint left, SpacePoint right) => (left.X, left.Y) == (right.X, right.Y);

    public static bool operator !=(SpacePoint left, SpacePoint right) => !(left == right);
}
