using UnityEngine;
using System.Collections;

 public class Timer
{
    private float _time; 
    
    public Timer()
    {
        _time = Time.time;
    }

    public void Reset()
    {
        _time = Time.time;
    }

    public float GetTime()
    {
        return Time.time - _time;
    }
}
