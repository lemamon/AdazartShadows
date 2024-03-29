﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCharacterPlayer3 : MonoBehaviour
{
    int aux;
    public int aux1;
    bool right, left;
    public bool selected_player3,isAlive;
    public GameObject pressName;
    public Vector3 scaleImage;
    public Sprite archer, warrior, wizard;
    string[] shadowTextVector;
    Text shadowText, pressText;
    Sprite[] shadows;
    GameObject shadowName;
    public GameObject arrow;
    SpriteRenderer shadowImage;
    GameObject player3;

    void Start()
    {
        arrow = GameObject.Find("Arrows3");
        shadowTextVector = new string[] { "Warrior", "Archer", "Wizard" };
        shadows = new Sprite[] { warrior, archer, wizard };
        shadowImage = GameObject.Find("ShadowImage3").GetComponent<SpriteRenderer>();
        shadowName = GameObject.Find("ShadowText3");
        shadowText = shadowName.GetComponent<Text>();
        shadowImage.sprite = shadows[0];
        shadowText.text = shadowTextVector[0];
        player3 = GameObject.Find("Player3");
        player3.transform.localScale = Vector3.zero;
        pressName = GameObject.Find("PressText3");
        pressText = pressName.GetComponent<Text>();
        aux = 0;
        aux1 = 1;
        isAlive = false;
        right = true;
        left = true;
        selected_player3 = false;

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Joystick2Button3) && aux1 == 1)
        {
            aux1++;
            pressName.SetActive(false);
            player3.transform.localScale = new Vector3(scaleImage.x, scaleImage.y, scaleImage.z);
            isAlive = true;
        }
        //Entradas
        if(aux1 != 1){
            if (selected_player3 == false)
            {
                if (Input.GetAxis("Player3_Horizontal") > 0 && right)
                {
                    right = false;
                    ChangeCharacterRight();
                    Invoke("DelayRight", 0.5f);
                }
                if (Input.GetAxis("Player3_Horizontal") < 0 && left)
                {
                    left = false;
                    ChangeCharacterLeft();
                    Invoke("DelayLeft", 0.5f);
                }
            }

            if (Input.GetAxis("Player3_Fire1") > 0 && aux1!= 1)
            {
                PlayerPrefs.SetInt("character3", aux);
                selected_player3 = true;
                arrow.SetActive(false);
            }

            if (Input.GetAxis("Player3_Fire2") > 0)
            {
                arrow.SetActive(true);
                selected_player3 = false;
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

    void ChangeCharacterRight()
    {
        aux++;
        if (aux > 2)
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
