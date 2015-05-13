using UnityEngine;
using System.Collections;

public class PlayerArcher : GenericPlayer
{
    private string _status;
    private Timer _canAttack;

    void Awake()
    {
        _speed      = 30f;
        _projectile = 2;
        _canAttack = new Timer(1f);
    }

    public override string Action1(float time, int[] direction)
    {
        if(_canAttack.GetTime() >= 1f)
        {
            _canAttack.Reset();
            if (direction[0] == 0 && direction[1] == 0)
                direction[0] = (int)transform.localScale.x;
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            return "Attack";
        }
        return null;
        
    }

    public override string Action2(float time, int[] direction)
    {

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
            }
        }
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
