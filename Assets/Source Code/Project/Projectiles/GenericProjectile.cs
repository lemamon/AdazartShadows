using UnityEngine;
using System.Collections;

public abstract class GenericProjectile : MonoBehaviour 
{
    protected float         _damage;
    protected GenericEffect _effect;
    protected Transform     _father;
    protected float         _speed;

    public abstract void SetOnLived(Vector2 direction);
}
