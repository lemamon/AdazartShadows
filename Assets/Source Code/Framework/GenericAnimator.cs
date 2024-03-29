﻿using UnityEngine;
using System.Collections;

public class GenericAnimator
{
    private Animator  _animator;
    private Transform _transform;
    private string    _name;

    public GenericAnimator(GameObject gameObject)
    {
        _animator  = gameObject.GetComponent<Animator>();
        _transform = gameObject.GetComponent<Transform>();
        _name      = gameObject.name;

    }

    public void Play(string animation)
    {
        //_animator.Play(_name+"_"+animation);
        if(!_animator.GetCurrentAnimatorStateInfo(0).IsName(_name + "_" + animation))
            _animator.SetTrigger(animation);
    }

    public void IsFacedRight(bool isFacedRight)
    {//Corrigir>>
        if(isFacedRight)
            _transform.localScale = new Vector3(Mathf.Abs(_transform.localScale.x), _transform.localScale.y, _transform.localScale.z);
        else
            _transform.localScale = new Vector3(-Mathf.Abs(_transform.localScale.x), _transform.localScale.y, _transform.localScale.z);
    }//<<
}
