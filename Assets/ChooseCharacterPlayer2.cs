using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCharacterPlayer2 : MonoBehaviour {
    int aux;
    bool right, left;
    public bool selected_player2;
    public Sprite archer, warrior, wizard;
    string[] shadowTextVector;
    Text shadowText;
    Sprite[] shadows;
    GameObject shadowName;
    SpriteRenderer shadowImage;

    void Start () {
        shadowTextVector = new string[] {"Warrior","Archer", "Wizard" };
        shadows = new Sprite[] { warrior, archer,wizard };
        shadowImage = GameObject.Find("ShadowImage2").GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText2");
        shadowText  = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        aux  = 0;
        right = true;
        left = true;
        selected_player2 = false;
        
    }

    void Update()
    {
        //Entradas
        if (!selected_player2)
        {
            if (Input.GetAxis("Player2_Horizontal") > 0 && right)
            {
                right = false;
                ChangeCaracterRight();
                Invoke("DelayRight", 0.5f);
            }
            if (Input.GetAxis("Player2_Horizontal") < 0 && left)
            {
                left = false;
                ChangeCaracterLeft();
                Invoke("DelayLeft", 0.5f);
            }
        }

        if (Input.GetAxis("Player2_Fire1") > 0)
        {
            selected_player2 = true;
            PlayerPrefs.SetInt("character2", aux);
        }
            
        if (Input.GetAxis("Player2_Fire2") > 0)
            selected_player2 = false;
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


