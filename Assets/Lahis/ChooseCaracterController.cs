using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ChooseCaracterController : MonoBehaviour {
    
    int aux, aux2;
    Text shadowText;
    GameObject shadowName;
    SpriteRenderer shadowImage;
    public Sprite archer, warrior, wizard;
    StandaloneInputModule[] mods;

    void Start () {
        shadowImage = GameObject.Find("ShadowImage").GetComponent<SpriteRenderer>();
        shadowName  = GameObject.Find("ShadowText");
        shadowText  = shadowName.GetComponent<Text>();
        
        mods = EventSystem.current.GetComponentsInChildren<StandaloneInputModule>();
        shadowText.text = "Archer";
        aux  = 0;
        aux2 = 0;

    }
    public void ChangeCaracterRight () {
        aux2 = 0;
        aux++;
        
        switch (aux){
            case 1:
                Debug.Log(" 1");
                mods[0].submitButton = "Player1_Horizontal";
                shadowImage.sprite = warrior;
                shadowText.text = "Warrior";
                break;
            case 2:
                Debug.Log("2");
                shadowImage.sprite = wizard;
                shadowText.text = "Wizard";
                break;
            //default:
              //  aux = 0; 
                //Loop:
                //shadowImage.sprite = archer;
                //shadowText.text = "Archer";
              //  break;
        }
    }

    public void ChangeCaracterLeft()
    {
        aux = 0;
        aux2++;
        switch (aux2)
        {
            case 1:
                mods[0].submitButton = "Player1_Horizontal";
                shadowImage.sprite = archer;
                shadowText.text = "Archer";
                break;
            case 2:
                shadowImage.sprite = wizard;
                shadowText.text = "Wizard";
                break;
            case 3:
                shadowImage.sprite = warrior;
                shadowText.text = "Warrior";
                break;
            //default:
                //aux2 = 0;
                //Loop:
                //shadowImage.sprite = archer;
                //shadowText.text = "Archer";
               // break;
        }
    }
}
