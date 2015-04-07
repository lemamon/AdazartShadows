
using UnityEngine;
using System.Collections;

public class PlayerWizzard : GenericPlayer
{

    public override string Action1(float time, int[] direction)
    {
        return "ss";
    }

    public override string Action2(float time, int[] direction)
    {
        return "ss";
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
