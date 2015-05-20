using UnityEngine;
using System.Collections;

public class ChangeToGame : MonoBehaviour {

    ChooseCaracterPlayer1 p1;
    ChooseCharacterPlayer2 p2;
    ChooseCharacterPlayer3 p3;
    void Start () {
        p1 = GameObject.Find("Player1").GetComponent<ChooseCaracterPlayer1>();
        p2 = GameObject.Find("Player2").GetComponent<ChooseCharacterPlayer2>();
        p3 = GameObject.Find("Player3").GetComponent<ChooseCharacterPlayer3>();
	}
	
	void Update () {
	    if (p1.selected_player1 && p2.selected_player2){
            Application.LoadLevel("Game");
            PlayerPrefs.SetInt("character3", -1);
        }
	}
}
