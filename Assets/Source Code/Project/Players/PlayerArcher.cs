using UnityEngine;
using System.Collections;

public class PlayerArcher : GenericPlayer
{

    public override string Action1(float time, int[] direction)
    {
        return null;
    }

    public override string Action2(float time, int[] direction)
    {
        return null;
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
