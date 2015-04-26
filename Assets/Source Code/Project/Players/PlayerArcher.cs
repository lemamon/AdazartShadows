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

    public override string Action1(float time, int[] direction)
    {
        if (direction[0] == 0 && direction[1] == 0)
            direction[0] = (int) transform.localScale.x;
        _facadePlayer.SpawProjectile(new Vector2(direction[0], direction[1]));
        return "Attack";
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
