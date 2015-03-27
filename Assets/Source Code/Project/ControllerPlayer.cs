using UnityEngine;
using System.Collections;

public class ControllerPlayer
{
    private Transform _noChaoCheck1;
    private Transform _noChaoCheck2;

    public ControllerPlayer(GameObject gameObject)
    {
        _noChaoCheck1 = gameObject.transform.Find("Controller/Check Grounded 1");
        _noChaoCheck2 = gameObject.transform.Find("Controller/Check Grounded 2");
    }

    public bool IsNoChao()
    {
        return Physics2D.Linecast(_noChaoCheck1.position, _noChaoCheck2.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
