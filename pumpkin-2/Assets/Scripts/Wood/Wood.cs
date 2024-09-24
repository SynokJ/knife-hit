using UnityEngine;

public class Wood : MonoBehaviour
{

    private const float _WOOD_MOVEMENT_SPEED = 50.0f;

    private void Update()
    {
        transform.Rotate(UnityEngine.Vector3.back * _WOOD_MOVEMENT_SPEED * UnityEngine.Time.deltaTime);
    }
}
