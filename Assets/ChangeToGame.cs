using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeToGame : MonoBehaviour {
    
    ChooseCharacterPlayer1 p1;
    ChooseCharacterPlayer2 p2;
    ChooseCharacterPlayer3 p3;
    GameObject ready;

    void Start () {
        p1 = GameObject.Find("Player1").GetComponent<ChooseCharacterPlayer1>();
        p2 = GameObject.Find("Player2").GetComponent<ChooseCharacterPlayer2>();
        p3 = GameObject.Find("Player3").GetComponent<ChooseCharacterPlayer3>();
        ready = GameObject.Find("ready");
        ready.transform.localScale = Vector2.zero;
    }
	
	void Update () {
      //Player 1 e 2:
      if(p3.isAlive == false){
          //Seleciona
          if (ready.transform.localScale.x == 1 && (Input.GetAxis("Player1_Fire1") > 0 || Input.GetAxis("Player2_Fire1") > 0))
          {
              PlayerPrefs.SetInt("character3", -1);
              Application.LoadLevel("Game");
          }
          //Diiiseleciona
          else if (ready.transform.localScale.x == 1 && (Input.GetKey(KeyCode.Z) || Input.GetAxis("Player2_Fire2") > 0))
              ready.transform.localScale = Vector2.zero;
          else if (p1.selected_player1 && p2.selected_player2)
          {
              ready.transform.localScale = Vector2.one;
              Input.ResetInputAxes();
          }
      }
      else// player 1,2 e 3 :p
      {
          Debug.Log("p1: " +p1.selected_player1 );
          Debug.Log("p2: " + p2.selected_player2);
          Debug.Log("p3: " + p3.selected_player3);
          //Seleciona
          if (ready.transform.localScale.x == 1 && (Input.GetAxis("Player1_Fire1") > 0 || Input.GetAxis("Player2_Fire1") > 0 || Input.GetAxis("Player3_Fire1") > 0))
              Application.LoadLevel("Game");
          //Diiiseleciona
          else if (ready.transform.localScale.x == 1 && (Input.GetKey(KeyCode.Z) || Input.GetAxis("Player2_Fire2") > 0 || Input.GetAxis("Player3_Fire2") > 0))
              ready.transform.localScale = Vector2.zero;
          else if (p3.selected_player3 && p1.selected_player1 && p2.selected_player2)
          {
              ready.transform.localScale = Vector2.one;
              Input.ResetInputAxes();
          }
      } 
    }
}
