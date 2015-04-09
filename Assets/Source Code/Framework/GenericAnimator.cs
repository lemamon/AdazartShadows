using UnityEngine;
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
    {
        if(isFacedRight)
            _transform.localScale = new Vector3(1, 1, 1);
        else
            _transform.localScale = new Vector3(-1, 1, 1);
    }
}
