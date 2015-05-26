using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCharacterPlayer1 : MonoBehaviour {

    int aux;
    public int aux1;
    bool right, left;
    public Vector3 scaleImage;
    public bool selected_player1;
    public Sprite archer, warrior, wizard;
    public GameObject pressName;
    string[] shadowTextVector;
    Text shadowText, pressText;
    Sprite[] shadows;
    GameObject shadowName;
    public GameObject arrow;
    SpriteRenderer shadowImage;
    GameObject player1;

    void Start () {
        arrow = GameObject.Find("Arrows1");
        shadowTextVector = new string[] { "Warrior", "Archer", "Wizard" };
        shadows = new Sprite[] { warrior, archer, wizard };
        shadowImage = GameObject.Find("ShadowImage1").GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText1");
        shadowText  = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        player1 = GameObject.Find("Player1");
        player1.transform.localScale = Vector3.zero;
        pressName = GameObject.Find("PressText1");
        pressText = pressName.GetComponent<Text>();
        aux  = 0;
        aux1 = 1;
        right = true;
        left = true;
        selected_player1 = false;
        
    }

    void Update()
    {
        //PressKey
        if (Input.GetKey(KeyCode.X) && aux1 == 1)
        {
             aux1++;
             pressName.SetActive(false);
             player1.transform.localScale = new Vector3(scaleImage.x, scaleImage.y, scaleImage.z);
            
        }
        if(aux1 != 1){
            //Entradas
            if (!selected_player1)
            {
                if (Input.GetAxis("Player1_Horizontal") > 0 && right)
                {
                    right = false;
                    ChangeCharacterRight();
                    Invoke("DelayRight", 0.5f);
                }
                if (Input.GetAxis("Player1_Horizontal") < 0 && left)
                {
                    left = false;
                    ChangeCharacterLeft();
                    Invoke("DelayLeft", 0.5f);
                }
            }

            if (Input.GetAxis("Player1_Jump") > 0 && aux1 != 1)
            {
                PlayerPrefs.SetInt("character1", aux);
                selected_player1 = true;
                arrow.SetActive(false);
            }

            if (Input.GetKey(KeyCode.Z))
            {
                arrow.SetActive(true);
                selected_player1 = false;
                /*aux1 = 1;
                pressName.SetActive(true);
                player1.transform.localScale = Vector3.zero;*/
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

