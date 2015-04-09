using UnityEngine;
using System.Collections;

public class PlayerArcher : GenericPlayer
{

<<<<<<< HEAD
<<<<<<< HEAD
    public override string Action1(float time, int[] direction)
    {
        return null;
=======

    public override string Action1(float time, int[] direction)
    {
        throw new System.NotImplementedException();
>>>>>>> 6ae659ca51b157db1445309c7d5bb0f33cda1615
=======
    public override string Action1(float time, int[] direction)
    {
        return null;
>>>>>>> Lahis
    }

    public override string Action2(float time, int[] direction)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        return null;
=======
        throw new System.NotImplementedException();
>>>>>>> 6ae659ca51b157db1445309c7d5bb0f33cda1615
=======
        return null;
>>>>>>> Lahis
    }

    public override bool CanJump()
    {
        throw new System.NotImplementedException();
    }

    public override bool CanMove()
    {
        throw new System.NotImplementedException();
    }
}
