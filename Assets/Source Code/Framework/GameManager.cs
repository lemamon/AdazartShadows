using UnityEngine;
using System.Collections;

public class GameManager
{

    private static GameManager _gameManager;
    private GameManager(){}
    public static GameManager Get()
    {
            if (_gameManager == null)
            {
                _gameManager = new GameManager();
            }

            return _gameManager;
    }
    public object GetObjectOfScreenByName(string objectName)
    {
        return GameObject.Find(objectName);
    }
    public object GetObjectOfRecouseByName(string objectName)
    {
        return Resources.Load("Prefabs/" + objectName, typeof(GameObject));
    }
}
