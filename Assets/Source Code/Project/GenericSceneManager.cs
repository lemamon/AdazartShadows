using UnityEngine;
using System.Collections;

public class GenericSceneManager : MonoBehaviour
{
    public void Begin(int[] players)
    {
        for (int i = 0; i < players.Length; i++ )
            {
                if (players[i] == 0)
                {
                    GenericGamepad pad = gameObject.AddComponent<GenericGamepad>();
                    pad._aux = players[i];
                }
            }
    }
    
    public void End()
    {

    }
}
