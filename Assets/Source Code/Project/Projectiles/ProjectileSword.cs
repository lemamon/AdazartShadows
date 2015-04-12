using UnityEngine;
using System.Collections;

public class ProjectileSword : GenericProjectile
{
    public void OnEnable()
    {
        Invoke("Kill", 0.2f);
    }

    public void Kill()
    {
        gameObject.Recycle();
    }

    public override void SetOnLived(Vector2 direction)
    {
    }
}
