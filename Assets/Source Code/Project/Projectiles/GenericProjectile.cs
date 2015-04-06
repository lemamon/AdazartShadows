using UnityEngine;
using System.Collections;

public abstract class GenericProjectile : MonoBehaviour 
{
    protected float         _speed;
    protected GenericEffect _effect;
    protected Transform     _father;
    protected float         _damage;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        return _speed;
    }
}
