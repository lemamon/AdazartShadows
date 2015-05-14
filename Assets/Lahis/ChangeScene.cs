using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public float time;
    public string scene;
    private bool flag;
    
	void Start () {
        flag = false;
        if (Application.loadedLevelName == "LudusSplash")
        {
            Invoke("GoToScene", time);
        }
        else
            flag = true;
       	
	}

    void Update()
    {
        if(flag && Input.anyKey)
            GoToScene();
    }

	void GoToScene () {
        Application.LoadLevel(scene);
	}

    
}
