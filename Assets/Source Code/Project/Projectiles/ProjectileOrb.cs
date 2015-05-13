using UnityEngine;
using System.Collections;

public class ProjectileOrb : GenericProjectile
{
    public void OnEnable()
    {
        _speed = 50;
    }

    public void OnDisable()
    {
        transform.localScale = new Vector3(1, 1, 1);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public override void SetOnLived(Vector2 direction, string player, Transform father)
    {
        _player = player;
        GetComponent<Rigidbody2D>().velocity = direction * _speed;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        try
        {
            if (c.CompareTag("Ground"))
            {
                Kill();
            }
            else if (c.CompareTag("Player") && c.name != _player)
            {

                Kill();
            }
            else if (c.CompareTag("Projectile") && c.GetComponent<GenericProjectile>().GetPlayer() != _player)
            {
                _player = c.GetComponent<GenericProjectile>().GetPlayer();
                GetComponent<Rigidbody2D>().velocity *= -1;
                transform.localScale = transform.localScale * -1;
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
            Kill();
        }
    }

    void Kill()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
        GetComponent<Animator>().SetTrigger("Explosion");
        Invoke("Kill1",3f);
    }

    void Kill1()
    {

    }
}
