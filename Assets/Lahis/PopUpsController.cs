using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PopUpsController : MonoBehaviour {

    Animator btMenu;
    StandaloneInputModule[] mods;
    GameObject settingsPopUp, choosePopUp, creditPopUp, menuPopup, btStart, btArrow;
    ChooseCharacterPlayer2 player2;
    ChooseCharacterPlayer3 player3;

    void Start()
    {
        player2 = GameObject.Find("Player2").GetComponent<ChooseCharacterPlayer2>();
        player3 = GameObject.Find("Player2").GetComponent<ChooseCharacterPlayer3>();
        mods          = EventSystem.current.GetComponentsInChildren<StandaloneInputModule>();
        btStart       = GameObject.Find("ButtonStart");
        btArrow       = GameObject.Find("ArrowRight1Button");
        menuPopup     = GameObject.Find("CanvasMenu");
        choosePopUp   = GameObject.Find("CanvasChooseCharacter");
        creditPopUp   = GameObject.Find("CanvasCredits");
        settingsPopUp = GameObject.Find("CanvasSettings");
        //btMenu = btStart.GetComponent<Animator>();
        
        EventSystem.current.firstSelectedGameObject = btStart;
        choosePopUp.SetActive(false);
        creditPopUp.SetActive(false);
        settingsPopUp.SetActive(false);
        menuPopup.SetActive(true);
    }
    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetAxis("Player2_Fire1") > 0 && player2.selected_player2) || (Input.GetAxis("Player3_Fire1") > 0 && player3.selected_player3))
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            mods[0].submitButton = "Player1_Submit";
            mods[1].submitButton = "Player2_Submit";
            mods[2].submitButton = "Player3_Submit";
            EventSystem.current.firstSelectedGameObject = btStart;
           // btMenu.SetTrigger("Restart");
            menuPopup.SetActive(true);
            choosePopUp.SetActive(false);
            creditPopUp.SetActive(false);
            settingsPopUp.SetActive(false);
           
        }
    }

    public void PopUp(int popUp)
    {
        menuPopup.SetActive(false);
        switch (popUp){
            case 0: //start
               choosePopUp.SetActive(true);
                creditPopUp.SetActive(false);
                settingsPopUp.SetActive(false); 
                mods[0].submitButton = "Player1_Horizontal";
                mods[1].submitButton = "Player2_Horizontal";
                mods[2].submitButton = "Player3_Horizontal";
                break;
            case 1: //settings
                choosePopUp.SetActive(false);
                creditPopUp.SetActive(false);
                settingsPopUp.SetActive(true); 
                break;
            case 2: // credits
                choosePopUp.SetActive(false);
                creditPopUp.SetActive(true);
                settingsPopUp.SetActive(false); 
                break;
            case 3: // exit
                Debug.Log("QUIT");
                Application.Quit();
                break;
        }
    }
}
