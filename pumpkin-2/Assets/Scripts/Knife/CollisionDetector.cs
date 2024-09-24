public class CollisionDetector
{
    private UnityEngine.Transform _knifeTr;

    public CollisionDetector(UnityEngine.Transform knifeTr)
    {
        _knifeTr = knifeTr;
    }

    ~CollisionDetector()
    {
    }

    public void ResponsCollision(Knife knife)
        => UnityEngine.Debug.Log("Game Over");

    public void ResponsCollision(Wood wood)
        => _knifeTr.SetParent(wood.transform);
}
