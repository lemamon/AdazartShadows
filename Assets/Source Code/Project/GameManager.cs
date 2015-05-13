using UnityEngine;
using System.Collections;

public class GameManager
{
    public static int                 _totalPlayers;
    public static int[]               _characters;
    public static GenericSceneManager _genericSceneManager;

    private GameManager(){}

    public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
