namespace OutlandArea.Interfaces.Universe.CelestialObjects;

[Serializable]
public enum CelestialObjectTypes
{
    PointInMap = -1,
    Asteroid = 1,
    Wreck = 10,
    Station = 100,
    SpaceshipPlayer = 200,
    SpaceshipNpcNeutral = 201,
    SpaceshipNpcEnemy = 202,
    SpaceshipNpcFriend = 203,
    Missile = 300,
    Explosion = 800
}
