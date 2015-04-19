using UnityEngine;
using System.Collections;

public class PlayerWarrior : GenericPlayer
{
    private Timer _canAttack;
    private string _status;

    void Awake()
    {
        _speed      = 20f;
        _projectile = 2;
        _canAttack  = new Timer(0.5f);
    }

    public override string Action1(float time, int[] direction)
    {
        if (_canAttack.GetTime() > 0.5f)
        {
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            _canAttack.Reset();
            return "Attack";
        }
        return null;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (_status != "Dead")
        {
            if (c.CompareTag("Projectile") && c.GetComponent<GenericProjectile>().GetPlayer() != _facadePlayer.GetPlayer())
            {
                _status = "Dead";
                _facadePlayer.Kill();
                Destroy(gameObject);
            }
        }
    }

    public override string Action2(float time, int[] direction)
    {
        return "ss";
    }

    public override bool CanJump()
    {
        return true;
    }

    public override bool CanMove()
    {
        return true;
    }
}
