
using UnityEngine;
using System.Collections;

public class PlayerWizzard : GenericPlayer
{
    Timer timer;
    bool action = false;

    public override string Action1(float time, int[] direction)
    {
        if (time > 0)
            action = false;
        else
            action = true;

        return null;
    }

    public override string Action2(float time, int[] direction)
    {
        if (time > 0)
            action = false;
        else
            action = true;
        return null;
    }

    public override bool CanJump()
    {
        if (action)
            return false;
        else
            return true;
    }

    public override bool CanMove()
    {
        if (action)
            return false;
        else
            return true;
    }
}
