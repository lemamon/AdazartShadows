using UnityEngine;
using System.Collections;

public abstract class Projectile : MonoBehaviour
{
    private GameObject _father;
    private float _speed;
    private GenericEffect _effect;
    private float _damage;
}
