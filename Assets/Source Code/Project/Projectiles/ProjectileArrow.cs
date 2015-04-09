using UnityEngine;
using System.Collections;

public class ProjectileArrow : GenericProjectile
{
    public void OnEnable()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(20, 0);
    }

    public void OnDisable()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
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
