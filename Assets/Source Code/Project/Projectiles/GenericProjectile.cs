using UnityEngine;
using System.Collections;

public class GenericProjectile : MonoBehaviour 
{
    private float         _speed;
    private GenericEffect _effect;
    private Transform     _father;
    private float         _damage;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        return _speed;
    }
}
