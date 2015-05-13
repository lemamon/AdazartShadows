
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWizzard : GenericPlayer
{
    private string _status;
    private List<Timer> _canAttack = new List<Timer>();
    void Awake()
    {
        _speed = 30f;
        _projectile = 3;
        _canAttack.Add(new Timer(-3f));
        _canAttack.Add(new Timer(-3f));
        _canAttack.Add(new Timer(-3f));

    }
    public override string Action1(float time, int[] direction)
    {//Corrigir>>
        if (direction[0] == 0 && direction[1] == 0)
            direction[0] = (int)transform.localScale.x/3;

        if (_canAttack[0].GetTime() >= 3f)
        {
            _canAttack[0].Reset();
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            return "Attack";
        }
        else if (_canAttack[1].GetTime() >= 3f)
        {
            _canAttack[1].Reset();
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            return "Attack";
        }
        else if (_canAttack[2].GetTime() >= 3f)
        {
            _canAttack[2].Reset();
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            return "Attack";
        }
        return null;
    }//<<

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

    public override string Action2(float time, int[] direction)
    {

        return null;
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
