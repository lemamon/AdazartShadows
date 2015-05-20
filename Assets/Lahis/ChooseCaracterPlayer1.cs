using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCaracterPlayer1 : MonoBehaviour {
    int aux;
    bool right, left;
    public bool selected_player1;
    public Sprite archer, warrior, wizard;
    string[] shadowTextVector;
    Text shadowText;
    Sprite[] shadows;
    GameObject shadowName;
    SpriteRenderer shadowImage;

    void Start () {
        shadowTextVector = new string[] { "Warrior", "Archer", "Wizard" };
        shadows = new Sprite[] { warrior, archer, wizard };
        shadowImage = GameObject.Find("ShadowImage1").GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText1");
        shadowText  = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        aux  = 0;
        right = true;
        left = true;
        selected_player1 = false;
        
    }

    void Update()
    {
        //Entradas
        if (!selected_player1)
        {
            if (Input.GetAxis("Player1_Horizontal") > 0 && right)
            {
                right = false;
                ChangeCaracterRight();
                Invoke("DelayRight", 0.5f);
            }
            if (Input.GetAxis("Player1_Horizontal") < 0 && left)
            {
                left = false;
                ChangeCaracterLeft();
                Invoke("DelayLeft", 0.5f);
            }
        }

        if (Input.GetAxis("Player1_Jump") > 0)
        {
            PlayerPrefs.SetInt("character1", aux);
            selected_player1 = true;
        }
            
        if (Input.GetKey(KeyCode.Z))
            selected_player1 = false;
    }

    void DelayLeft()
    {
        left = true;
    }

    void DelayRight()
    {
        right = true;
    }

    void ChangeCaracterRight () {
        aux++;
        if(aux > 2)
            aux = 0;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
    }

    void ChangeCaracterLeft()
    {
        aux--;
        if (aux < 0)
            aux = 2;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
    }
}

