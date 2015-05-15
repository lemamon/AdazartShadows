using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCaracterPlayer1 : MonoBehaviour {
    int aux;
    bool right, left, selected;
    public string playerNumber;
    public Sprite archer, warrior, wizard;
    string[] shadowTextVector;
    Text shadowText;
    Sprite[] shadows;
    GameObject shadowName;
    SpriteRenderer shadowImage;

    void Start () {
        shadowTextVector = new string[] { "Archer", "Warrior", "Wizard" };
        shadows = new Sprite[] { archer ,warrior,wizard};
        shadowImage = GameObject.Find("ShadowImage" + playerNumber).GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText" + playerNumber);
        shadowText  = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        aux  = 0;
        right = true;
        left = true;
        selected = true;
    }

    void Update()
    {
        //Entradas
        if (Input.GetAxis("Player" + playerNumber + "_Horizontal") > 0 && right)
        {
            right = false;
            ChangeCaracterRight();
            Invoke("DelayRight", 0.5f);
        }
        if (Input.GetAxis("Player" + playerNumber + "_Horizontal") < 0 && left)
        {
            left = false;
            ChangeCaracterLeft();
            Invoke("DelayLeft", 0.5f);
        }
        if (Input.GetKey(KeyCode.Space) && selected)
        {
            Application.LoadLevel("Game");
            selected = false;
            Invoke("DelaySelected", 0.5f);
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

    void DelaySelected()
    {
        selected = true;
    }

    public void ChangeCaracterRight () {
        aux++;
        if(aux > 2)
            aux = 0;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
        PlayerPrefs.SetInt(playerNumber.ToString(),aux);
    }

    public void ChangeCaracterLeft()
    {
        aux--;
        if (aux < 0)
            aux = 2;
        shadowImage.sprite = shadows[aux];
        shadowText.text = shadowTextVector[aux];
        PlayerPrefs.SetInt(playerNumber.ToString(), aux);
    }
}


