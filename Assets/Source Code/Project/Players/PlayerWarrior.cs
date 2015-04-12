using UnityEngine;
using System.Collections;

public class PlayerWarrior : GenericPlayer
{
    private Timer _canAttack;

    void Awake()
    {
        _speed      = 20f;
        _projectile = 1;
        _canAttack  = new Timer(0.5f);
    }

    public override string Action1(float time, int[] direction)
    {
<<<<<<< HEAD
        if (_canAttack.GetTime() > 0.5f)
        {
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            _canAttack.Reset();
            return "Attack";
        }
        return null;
=======
        _facadePlayer.SpawProjectile();

        return "ss";
>>>>>>> a53ff44389e4094ba258f241d309362bf99c5a3f
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
