using UnityEngine;
using System.Collections;

public abstract class GenericPlayer : MonoBehaviour
{
    private float        _speed;
    public FacadePlayer _facadePlayer;
    void Awake()
    {
        _speed = 5f;
    }
    public abstract string Action1(float time, int[] direction);
    public abstract string Action2(float time, int[] direction);
    public abstract bool CanJump();
    public abstract bool CanMove();

    public void SetFacadePlayer(FacadePlayer facadePlayer)
    {
        _facadePlayer = facadePlayer;
    }

    public float GetSpeed()
    {
        return _speed;
    }
}
