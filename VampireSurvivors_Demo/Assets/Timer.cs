using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerNum;
    public float timer;
    private void Awake() {
        TimerNum = GetComponentInChildren<Text>();
    }
    private void Update() {
        timer += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(timer);
        TimerNum.text = time.Minutes.ToString()+":"+time.Seconds.ToString();
    }

}
