
using UnityEngine;
using System.Collections;

public class PlayerWizzard : GenericPlayer
{

    public override string Action1(float time, int[] direction)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
>>>>>>> Lahis
        if (time > 0)
            action = false;
        else
            action = true;
<<<<<<< HEAD
        return null;
=======
        return "ss";
>>>>>>> 6ae659ca51b157db1445309c7d5bb0f33cda1615
=======

        return null;
>>>>>>> Lahis
    }

    public override string Action2(float time, int[] direction)
    {
<<<<<<< HEAD
        if (time > 0)
            action = false;
        else
            action = true;
        return null;
<<<<<<< HEAD
=======
        return "ss";
>>>>>>> 6ae659ca51b157db1445309c7d5bb0f33cda1615
=======
>>>>>>> Lahis
    }

    public override bool CanJump()
    {
        return true;
    }

    public override bool CanMove()
    {
        return true;
    }
}
