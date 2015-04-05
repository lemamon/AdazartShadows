using UnityEngine;
using System.Collections;

public class FacadePlayer
{
    private GenericAnimator  _genericAnimator;
    private GameObject       _gameObject;
    private Rigidbody2D      _rigidbody2D;
    private GenericMovement  _genericMovement;
    private GenericPlayer    _genericPlayer;
    private ControllerPlayer _controllerPlayer;
    private bool             _isJumping;
    public FacadePlayer()
    {
        _isJumping        = false;
        _genericPlayer    = Factory.InstancePlayer(1);
        _gameObject       = _genericPlayer.gameObject;
        _rigidbody2D      = _gameObject.GetComponent<Rigidbody2D>();
        _genericAnimator  = new GenericAnimator(_gameObject);
        _genericMovement  = new GenericMovement(_gameObject);
        _controllerPlayer = new ControllerPlayer(_gameObject);
        _genericPlayer.SetFacadePlayer(this);
    }
    public void MoveToDirection(int[] directions)//X and Y directions
    {
        if(_genericPlayer.CanMove())
        {
            switch(directions[0])//just moves X direction
            {
                case -1://Left
                    _genericMovement.Move(new Vector2(-_genericPlayer.GetSpeed(), _rigidbody2D.velocity.y));
                    _genericAnimator.Play("Walk");
                    _genericAnimator.IsFacedRight(false);
                    break;
                case  1://Right
                    _genericMovement.Move(new Vector2(_genericPlayer.GetSpeed(), _rigidbody2D.velocity.y));
                    _genericAnimator.Play("Walk");
                    _genericAnimator.IsFacedRight(true);
                    break;
                default://Both or Neither
                    _genericMovement.Move(new Vector2(0, _rigidbody2D.velocity.y));
                    _genericAnimator.Play("Idle");
                    break;
            }
        }
    }
    public void Action1(float time, int[] directions)
    {
        string anim = _genericPlayer.Action1(time, directions);
        anim = "Attack";
        _genericAnimator.Play(anim);
    }
    public void Action2(float time, int[] directions)
    {
        string anim = _genericPlayer.Action2(time, directions);
        anim = "Attack";
        _genericAnimator.Play(anim);
    }
    public void Jump()
    {
        if (/*_genericPlayer.CanJump() &&*/ _controllerPlayer.IsNoChao())
        {
            _genericMovement.Push(Vector2.up*1200);
        }
    }
    public void JumpOut()
    {
        if (_rigidbody2D.velocity.y > 0)
            {
                //(Velocity.x,0)
                _genericMovement.Move(Vector2.right * _rigidbody2D.velocity.x);
            }
    }
    public void SwapProjectile(GenericProjectile genericProjectile)
    {
        genericProjectile.Spawn();
    }
}