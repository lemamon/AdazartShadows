using UnityEngine;
using System.Collections;

public class PlayerWarrior : GenericPlayer
{


    void Awake()
    {
        _speed      = 20f;
        _projectile = 2;
    }

    public override string Action1(float time, int[] direction)
    {
<<<<<<< HEAD
       
=======
        _facadePlayer.SpawProjectile();
>>>>>>> 6ae659ca51b157db1445309c7d5bb0f33cda1615
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
