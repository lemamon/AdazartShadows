﻿
using UnityEngine;
using System.Collections;

public class PlayerWizzard : GenericPlayer
{
    private Timer timer;
    private bool  action = true;
    
    void Awake()
    {
        _projectile = 2;
        _speed = 20;
    }

    public override string Action1(float time, int[] direction)
    {
        Debug.Log(time);
        if (time > 0)
        {
            
            if (time > 2) time = 2;
            _facadePlayer.SpawProjectile(new Vector2(direction[0] * (time * 50), direction[1]) * (time * 50));
            action = true;
            return null;//anim atack
        }
        else
        {
            return null;//anim load
        }
    }

    public override string Action2(float time, int[] direction)
    {
        if (time > 0)
            action = false;
        else
            action = true;
        return "ss";
    }

    public override bool CanJump()
    {
        return action;
    }

    public override bool CanMove()
    {
        return action;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "")
        {
            gameObject.SetActive(false);
        }
    }
}
