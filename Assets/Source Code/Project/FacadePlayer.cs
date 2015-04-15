using UnityEngine;
using System.Collections;

public class FacadePlayer
{
    private bool              _isJumping;
    private ControllerPlayer  _controllerPlayer;
    private GameObject        _gameObject;
    private GenericAnimator   _genericAnimator;
    private GenericMovement   _genericMovement;
    private GenericPlayer     _genericPlayer;
    private GameObject        _projectile;
    private Rigidbody2D       _rigidbody2D;

    public FacadePlayer()
    {
        _isJumping         = false;
        _genericPlayer     = Factory.InstancePlayer(1);
        _projectile        = Factory.FindProjectile(_genericPlayer.GetProjectile());
        _gameObject        = _genericPlayer.gameObject;
        _rigidbody2D       = _gameObject.GetComponent<Rigidbody2D>();
        _genericAnimator   = new GenericAnimator(_gameObject);
        _genericMovement   = new GenericMovement(_gameObject);
        _controllerPlayer  = new ControllerPlayer(_gameObject);

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
                    _genericAnimator.IsFacedRight(false);
                    if (_controllerPlayer.IsGrounded())
                        _genericAnimator.Play("Walk");
                    break;
                case  1://Right
                    _genericMovement.Move(new Vector2(_genericPlayer.GetSpeed(), _rigidbody2D.velocity.y));
                    _genericAnimator.IsFacedRight(true);
                    if (_controllerPlayer.IsGrounded())
                        _genericAnimator.Play("Walk");
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
        if (_genericPlayer.CanJump() && _controllerPlayer.IsGrounded())
        {
            _genericAnimator.Play("Jump");
            _genericMovement.Push(Vector2.up*6000);
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
    public void SpawProjectile(Vector2 direction)
    {
        GameObject projectile = _projectile.Spawn(_gameObject.transform.position,_gameObject.transform.rotation);
        projectile.GetComponent<GenericProjectile>().SetOnLived(direction);
    }
}