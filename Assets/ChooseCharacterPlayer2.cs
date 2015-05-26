using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCharacterPlayer2 : MonoBehaviour {
    int aux;
    public int aux1;
    bool right, left;
    public Vector3 scaleImage;
    public bool selected_player2;
    public Sprite archer, warrior, wizard;
    public GameObject pressName;
    string[] shadowTextVector;
    Text shadowText, pressText;
    Sprite[] shadows;
    GameObject shadowName;
    public GameObject arrow;
    SpriteRenderer shadowImage;
    GameObject player2;

    void Start () {
        arrow = GameObject.Find("Arrows2");
        shadowTextVector = new string[] {"Warrior","Archer", "Wizard" };
        shadows = new Sprite[] { warrior, archer,wizard };
        shadowImage = GameObject.Find("ShadowImage2").GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText2");
        shadowText  = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        player2 = GameObject.Find("Player2");
        player2.transform.localScale = Vector3.zero;
        pressName = GameObject.Find("PressText2");
        pressText = pressName.GetComponent<Text>();
        aux  = 0;
        aux1 = 1;
        right = true;
        left = true;
        selected_player2 = false;
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button3) && aux1 == 1)
        {
            aux1++;
            pressName.SetActive(false);
            player2.transform.localScale = new Vector3(scaleImage.x, scaleImage.y, scaleImage.z);
           // selected_player2 = false;
        }
        if (aux1 != 1){
            //Entradas
            if (selected_player2 == false)
            {
                if (Input.GetAxis("Player2_Horizontal") > 0 && right)
                {
                    right = false;
                    ChangeCharacterRight();
                    Invoke("DelayRight", 0.5f);
                }
                if (Input.GetAxis("Player2_Horizontal") < 0 && left)
                {
                    left = false;
                    ChangeCharacterLeft();
                    Invoke("DelayLeft", 0.5f);
                }
            }

            if (Input.GetAxis("Player2_Fire1") > 0 && aux1 != 1)
            {
                selected_player2 = true;
                PlayerPrefs.SetInt("character2", aux);
                arrow.SetActive(false);
            }

            if (Input.GetAxis("Player2_Fire2") > 0) {
                arrow.SetActive(true);
                selected_player2 = false;
            }
        }
   
    }

    void DelayLeft()
    {
        left = true;
    }

    void DelayRight()
    {
        right = true;
    }

    void ChangeCharacterRight () {
        aux++;
        if(aux > 2)
            aux = 0;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
    }

    void ChangeCharacterLeft()
    {
        aux--;
        if (aux < 0)
            aux = 2;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
    }
}


