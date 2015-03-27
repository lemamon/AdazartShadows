using UnityEngine;
using System.Collections;

public class GenericMovement
{
    private Rigidbody2D _rigidbody2D;

    public GenericMovement(GameObject gameObject)
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 speed)
    {
        this._rigidbody2D.velocity = speed;
    }

    public void Push(Vector2 force)
    {
        this._rigidbody2D.AddForce(force);
    }
}
