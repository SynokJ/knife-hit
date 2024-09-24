using System;
using UnityEngine;

public class Knife : MonoBehaviour
{
    private CollisionDetector _collisionDetector;
    private KnifeMovement _movement;
    private UserInput _input;

    public event Action OnKnifeDashed = default;

    private bool _isDashed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Knife>(out Knife knife))
            _collisionDetector.ResponsCollision(knife); 

        if (collision.gameObject.TryGetComponent<Wood>(out Wood wood))
            _collisionDetector.ResponsCollision(wood);
    }

    void Awake()
    {
        _input = new UserInput();
        _movement = new KnifeMovement(GetComponent<Rigidbody2D>());
        _collisionDetector = new CollisionDetector(transform);
    }

    void Update()
    {
        if (_input.IsMouseClicked() && !_isDashed)
        {
            _movement.Dash();  
            OnKnifeDashed();

            _isDashed = true;
        }
    }

    public void Test()
        => _movement.Dash();
}
