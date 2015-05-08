using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PopUpsController : MonoBehaviour {

    GameObject settingsPopUp, choosePopUp, menuPopup, btStart, btArrow;
    
    void Awake()
    {
        choosePopUp   = GameObject.Find("CanvasChooseCharacter");
        settingsPopUp = GameObject.Find("CanvasSettings");
        menuPopup     = GameObject.Find("CanvasMenu");
        btStart       = GameObject.Find("ButtonStart");
        btArrow       = GameObject.Find("ArrowRight1Button");
        EventSystem.current.firstSelectedGameObject = btStart;
        choosePopUp.SetActive(false);
        menuPopup.SetActive(true);
    }

    public void PopUp(int popUp)
    {
        
        switch (popUp){
            case 0:
                choosePopUp.SetActive(true);
                menuPopup.SetActive(false);
                EventSystem.current.firstSelectedGameObject = btArrow;
               
                break;
            case 1:
                choosePopUp.SetActive(true);
                menuPopup.SetActive(false);
                EventSystem.current.firstSelectedGameObject = btStart;
                break;
            case 2:
                choosePopUp.SetActive(true);
                menuPopup.SetActive(false);
                EventSystem.current.firstSelectedGameObject = btStart;
                break;
        }

    }


}
