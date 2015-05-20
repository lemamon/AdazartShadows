using UnityEngine;
using System.Collections;

public class GenericSceneManager : MonoBehaviour
{
    int[] _aux = new int[3];
    public void Awake()
    {
        _aux[0] = PlayerPrefs.GetInt("character1") +1;
        Debug.Log(_aux[0]);
        _aux[1] = PlayerPrefs.GetInt("character2") +1;
        Debug.Log(_aux[1]);
        _aux[2] = PlayerPrefs.GetInt("character3")+1;
        Debug.Log(_aux[2]);
        Begin(_aux);
    }
    public void Begin(int[] players)
    {
        for (int i = 0; i < players.Length; i++ )
            {
                
                if (players[i] != 0)
                {
                    GenericGamepad pad = gameObject.AddComponent<GenericGamepad>();
                    pad._aux = players[i];
                    pad._player = "Player" + (i+1);
                    pad.enabled = true;
                    pad.Awake1();
                }
            }
    }
    
    public void End()
    {

    }
}
