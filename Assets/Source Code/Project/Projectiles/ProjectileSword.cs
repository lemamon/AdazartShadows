using UnityEngine;
using System.Collections;

public class ProjectileSword : GenericProjectile
{
    public void OnEnable()
    {
        Invoke("Kill", 3f);
    }

    public void Kill()
    {
        gameObject.Recycle();
    }
}
