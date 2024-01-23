using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private Text timeText;
    public String GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
    private void FixedUpdate() 
    {
        timeText.text = GetCurrentTime();    
    }
}
