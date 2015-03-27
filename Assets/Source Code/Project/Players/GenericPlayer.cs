using UnityEngine;
using System.Collections;

public abstract class GenericPlayer : MonoBehaviour
{
    private float _speed;
    void Awake()
    {
        _speed = 5f;
    }
    public abstract void Action1(float time, int[] direction);
    public abstract void Action2(float time, int[] direction);
    public abstract bool CanJump();
    public abstract bool CanMove();

    public float GetSpeed()
    {
        return _speed;
    }
}
