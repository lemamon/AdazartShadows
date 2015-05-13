using UnityEngine;
using System.Collections;

public abstract class Aggregate 
{
	public abstract Interator CreateInterator();
    public abstract Vector3 Get(int index);
    public abstract int       Count();
}
