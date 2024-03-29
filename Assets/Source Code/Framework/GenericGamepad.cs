﻿using UnityEngine;
using System.Collections;

public class GenericGamepad : MonoBehaviour
{
    public GenericSceneManager _sceneManager;
    private Timer        _action1;
    private Timer        _action2;
    private int[]        _directions;
    private FacadePlayer _facadePlayer;
    public int        _player;//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    public string _strPlayer;
    public int _aux;//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    public void Awake1()
    {
        _action1      = new Timer();
        _action2      = new Timer();
        _directions   = new int[2] {0,0};
        _facadePlayer = new FacadePlayer(_player,_aux);
        _facadePlayer._sceneManager = _sceneManager;
        _strPlayer = "Player" + _player;
    }

    void Update()
    {
        //Some key down?
        if(Input.anyKeyDown)
        {
            //Some action key down?
            if (/*Input.GetKeyDown(KeyCode.A) ||*/ Input.GetButtonDown(_strPlayer + "_" + "Fire1"))
            { 
                _action1.Reset();
                _directions[0] = DirectionX();
                _directions[1] = DirectionY();
                _facadePlayer.Action1(_action1.GetTime(),_directions);
            }
            if (/*Input.GetKeyDown(KeyCode.B) ||*/ Input.GetButtonDown(_strPlayer + "_" + "Fire2"))
            {
                _action2.Reset();
            }
            if (/*Input.GetKeyDown(KeyCode.Space) ||*/ Input.GetButtonDown(_strPlayer + "_" + "Jump"))
            {
                _facadePlayer.Jump();
            }
        }
        if (/* Input.GetKeyUp(KeyCode.Space) ||*/ Input.GetButtonUp(_strPlayer + "_" + "Jump"))
        {
            _facadePlayer.JumpOut();
        }
        _directions[0] = DirectionX();
        _directions[1] = DirectionY();
        _facadePlayer.MoveToDirection(_directions);
        if(Input.GetKeyUp(KeyCode.A))
            Debug.Log(_action1.GetTime());
        if(Input.GetKeyUp(KeyCode.B))
            Debug.Log(_action2.GetTime());
    }
    private int DirectionX()
    {
        //if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        //{
        //    return 0;
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    return -1;
        //else if (Input.GetKey(KeyCode.RightArrow))
        //    return 1;
        //return 0;
        return (int)Input.GetAxis(_strPlayer + "_" + "Horizontal");
    }
    private int DirectionY()
    {
        //if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        //{
        //    return 0;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //    return -1;
        //else if (Input.GetKey(KeyCode.UpArrow))
        //    return 1;
        //return 0;
        return (int)Input.GetAxis(_strPlayer + "_" + "Vertical");
    }
}
