using UnityEngine;
using System.Collections;

public abstract class Interator
{
    public abstract Vector3 First();
    public abstract Vector3 Next();
    public abstract Vector3 CurrentItem();
    public abstract bool   IsDone();
    
}
