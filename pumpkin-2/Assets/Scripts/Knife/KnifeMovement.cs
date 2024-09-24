public class KnifeMovement
{
    private const float _DASH_VALUE = 30.0f;

    private UnityEngine.Rigidbody2D _knifeRb;

    public KnifeMovement(UnityEngine.Rigidbody2D rb)
    {
        _knifeRb = rb;
    }

    ~KnifeMovement()
    {
        _knifeRb = null;
    }

    public void Dash()
    {
        var mode = UnityEngine.ForceMode2D.Impulse;
        _knifeRb.AddForce(UnityEngine.Vector2.up * _DASH_VALUE, mode);
    }
}
