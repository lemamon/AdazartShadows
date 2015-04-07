using UnityEngine;
using System.Collections;

public abstract class GenericPlayer : MonoBehaviour
{
    protected float        _speed;
    protected int          _projectile;
    protected FacadePlayer _facadePlayer;

    void Awake()
    {
        _speed      = 15;
        _projectile = 1;
    }

    public abstract string Action1(float time, int[] direction);
    public abstract string Action2(float time, int[] direction);
    public abstract bool   CanJump();
    public abstract bool   CanMove();
    
    public int GetProjectile()
    {
        return _projectile;
    }

    public void SetFacadePlayer(FacadePlayer facadePlayer)
    {
        _facadePlayer = facadePlayer;
    }

    public float GetSpeed()
    {
        return _speed;
    }

    
}
