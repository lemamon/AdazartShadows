using UnityEngine;
using System.Collections;

public class ProjectileSword : GenericProjectile
{

    public void OnEnable()
    {
        Invoke("Kill", 0.3f);
    }

    public void Kill()
    {
        gameObject.Recycle();
    }

    public override void SetOnLived(Vector2 direction, string player, Transform father)
    {
        transform.parent = father;
        _player = player;
    }
}
