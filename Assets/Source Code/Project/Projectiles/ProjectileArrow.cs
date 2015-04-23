using UnityEngine;
using System.Collections;

public class ProjectileArrow : GenericProjectile
{
    public void OnEnable()
    {
        _speed = 60;
    }

    public void OnDisable()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public override void SetOnLived(Vector2 direction, string player)
    {
        _player = player;
        GetComponent<Rigidbody2D>().velocity = direction*_speed;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.CompareTag("Ground"))
        {
            Kill();
        }
    }

    void Kill()
    {
        gameObject.Recycle();
    }

}
