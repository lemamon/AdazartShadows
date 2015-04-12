using UnityEngine;
using System.Collections;

public class ControllerPlayer
{
    private Transform _checkGrounded1;
    private Transform _checkGrounded2;

    public ControllerPlayer(GameObject gameObject)
    {
        _checkGrounded1 = gameObject.transform.Find("Controller/Check Grounded 1");
        _checkGrounded2 = gameObject.transform.Find("Controller/Check Grounded 2");
    }

    public bool IsGrounded()
    {
        return Physics2D.Linecast(_checkGrounded1.position, _checkGrounded2.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
