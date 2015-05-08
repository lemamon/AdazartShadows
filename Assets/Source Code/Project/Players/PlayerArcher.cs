using UnityEngine;
using System.Collections;

public class PlayerArcher : GenericPlayer
{
    private string _status;
    void Awake()
    {
        _speed = 20f;
        _projectile = 2;
    }

    private Timer _canAttack;

    void Awake()
    {
        _speed = 20f;
        _projectile = 2;
        _canAttack = new Timer(0.5f);
    }

    public override string Action1(float time, int[] direction)
    {
<<<<<<< HEAD
        if (direction[0] == 0 && direction[1] == 0)
            direction[0] = (int) transform.localScale.x;
        _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
        return "Attack";
=======
        if (_canAttack.GetTime() > 0.5f)
        {
            _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
            _canAttack.Reset();
            return "Attack";
        }
        return null;
>>>>>>> Lahis
    }

    public override string Action2(float time, int[] direction)
    {
<<<<<<< HEAD

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
=======
        return "ss";
>>>>>>> Lahis
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
