using UnityEngine;
using System.Collections;

public class TextAppear : MonoBehaviour {

    GameObject press;
    public float appearTime;
    
    void Start () {
        press = GameObject.Find("PressAny");
        press.SetActive(false);
        Invoke("Appear",appearTime);
	}
	
	void Appear () {
        press.SetActive(true);
	}
}
