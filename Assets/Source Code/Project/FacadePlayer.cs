﻿using UnityEngine;
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
        _genericPlayer     = Factory.InstancePlayer(2);
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
                    _genericAnimator.Play("Walk");
                    _genericAnimator.IsFacedRight(false);
                    break;
                case  1://Right
                    Debug.Log(_genericPlayer.GetSpeed());
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
        if (_genericPlayer.CanJump() && _controllerPlayer.IsNoChao())
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
    public void SpawProjectile()
    {
        _projectile.Spawn(_gameObject.transform.position,_gameObject.transform.rotation);
    }
}