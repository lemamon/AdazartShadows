using UnityEngine;
using System.Collections;

public class PlayerArcher : GenericPlayer
{

    public override void Action1(float time, int[] direction)
    {
    }

    public override void Action2(float time, int[] direction)
    {
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
