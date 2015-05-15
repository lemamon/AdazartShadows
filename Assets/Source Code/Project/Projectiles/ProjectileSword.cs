using UnityEngine;
using System.Collections;

public class ProjectileSword : GenericProjectile
{

    private AudioSource[] _aud;

    public void Awake()
    {
        _aud = GetComponents<AudioSource>();
    }

    public void OnEnable()
    {
        _aud[2].Play();
        Invoke("Kill", 0.3f);
    }

    public void Kill()
    {
        gameObject.Recycle();
    }

    public override void SetOnLived(Vector2 direction, string player, Transform father)
    {
        transform.parent = father;
        _player = player;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.CompareTag("Player"))
        {
            _aud[0].Play();
        }
        else if(c.CompareTag("Projectile"))
        {
            _aud[1].Play();
        }
    }
}
