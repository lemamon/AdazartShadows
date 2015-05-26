using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PopUpsController : MonoBehaviour {

    StandaloneInputModule[] mods;
    GameObject settingsPopUp, choosePopUp, creditPopUp, menuPopup, btStart, btArrow;
    ChooseCharacterPlayer1 player1;
    ChooseCharacterPlayer2 player2;
    ChooseCharacterPlayer3 player3;
    GameObject mainCamera;


    void Start()
    {
        PlayerPrefs.SetInt("player1_results",0);
        PlayerPrefs.SetInt("player2_results", 0);
        PlayerPrefs.SetInt("player3_results", 0);
        player1 = GameObject.Find("Player1").GetComponent<ChooseCharacterPlayer1>();
        player2 = GameObject.Find("Player2").GetComponent<ChooseCharacterPlayer2>();
        player3 = GameObject.Find("Player3").GetComponent<ChooseCharacterPlayer3>();
        mainCamera = GameObject.Find("MainCameraMenu");
        mods          = EventSystem.current.GetComponentsInChildren<StandaloneInputModule>();
        btStart       = GameObject.Find("ButtonStart");
        btArrow       = GameObject.Find("ArrowRight1Button");
        menuPopup     = GameObject.Find("CanvasMenu");
        choosePopUp   = GameObject.Find("CanvasChooseCharacter");
        creditPopUp   = GameObject.Find("CanvasCredits");
        settingsPopUp = GameObject.Find("CanvasSettings");
        EventSystem.current.firstSelectedGameObject = btStart;
        choosePopUp.SetActive(false);
        creditPopUp.SetActive(false);
        settingsPopUp.SetActive(false);
        menuPopup.SetActive(true);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) )//Reset
        {
            Application.LoadLevel("Menu");
            /*mods[0].submitButton = "Player1_Submit";
            mods[1].submitButton = "Player2_Submit";
            mods[2].submitButton = "Player3_Submit";
            EventSystem.current.firstSelectedGameObject = btStart;
            menuPopup.SetActive(true);
            choosePopUp.SetActive(false);
            creditPopUp.SetActive(false);
            settingsPopUp.SetActive(false);*/
        }
    }

    public void PopUp(int popUp)
    {
        menuPopup.SetActive(false);
        switch (popUp){
            case 0: //start
                mainCamera.AddComponent<ChangeToGame>();
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
                Debug.Log("Quit");
                Application.Quit();
                break;
        }
    }
}
