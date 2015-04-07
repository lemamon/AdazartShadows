using UnityEngine;
using System.Collections;

public class PlayerWarrior : GenericPlayer
{


    void Awake()
    {
        _speed      = 20f;
        _projectile = 1;
    }

    public override string Action1(float time, int[] direction)
    {
        _facadePlayer.SpawProjectile();
        return "ss";
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
