using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericSceneManager : MonoBehaviour
{
    ResultsController results;
    int flag;
    static int[] _aux = new int[3];
    static List<bool> _players = new List<bool>();
    public void Awake()
    {
        flag = 1;
        results = GameObject.Find("MainCamera").GetComponent<ResultsController>();
        _aux[0] = PlayerPrefs.GetInt("character1") +1;
        _aux[1] = PlayerPrefs.GetInt("character2") +1;
        _aux[2] = PlayerPrefs.GetInt("character3")+1;
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
                    pad._player = (i + 1);
                    pad.enabled = true;
                    pad._sceneManager = this;
                    pad.Awake1();

                    _players.Add(true);
                }
                else
                    _players.Add(false);
            }
    }
    public void End(int player)
    {
        int aux = 0;
        _players[player - 1] = false;

        foreach(bool aPlayer in _players)
        {
            if(aPlayer)
            {
                aux++;
            }
        }

        if(aux >= 1)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i] && flag == 1)
                {
                    flag++;
                    results.FinalResult(i);
                }
            }
        }
    }   
}
