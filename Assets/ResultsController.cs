using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultsController : MonoBehaviour {
   
    Text p1Victory;
    Text p2Victory;
    Text p3Victory;
    GameObject popUp;

	void Start () {
        popUp = GameObject.Find("PopUp");
        popUp.transform.localScale = Vector3.zero;
        p1Victory = GameObject.Find("p1_times").GetComponent<Text>();
        p2Victory = GameObject.Find("p2_times").GetComponent<Text>();
        p3Victory = GameObject.Find("p3_times").GetComponent<Text>();
	}
	
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }
    }
	 
	public void FinalResult (int i) {
      
        if( i == 1){
            
            PlayerPrefs.SetInt("player1_results", PlayerPrefs.GetInt("player1_results") + 1);
            Debug.Log("valor "+ PlayerPrefs.GetInt("player1_results"));
            p1Victory.text = " " + PlayerPrefs.GetInt("player1_results");
            popUp.transform.localScale = new Vector3(5.748483f, 5.748483f, 5.748483f);
        }
        else if (i == 2)
        {
            PlayerPrefs.SetInt("player2_results", PlayerPrefs.GetInt("player2_results") + 1);
            p2Victory.text = " " + PlayerPrefs.GetInt("player2_results");
            popUp.transform.localScale = new Vector3(5.748483f, 5.748483f, 5.748483f);
            Debug.Log("=2=");
        }
        else if (i == 3)
        {
            PlayerPrefs.SetInt("player3_results", PlayerPrefs.GetInt("player3_results") + 1);
            p3Victory.text = " " + PlayerPrefs.GetInt("player3_results");
            popUp.transform.localScale = new Vector3(5.748483f, 5.748483f, 5.748483f);
            Debug.Log("=3=");
        }
	}
}
