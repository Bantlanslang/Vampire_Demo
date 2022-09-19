using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    PlayerState playerState;

    private void Awake() {

        playerState = FindObjectOfType<PlayerState>();
        slider = GetComponentInChildren<Slider>();
    }
    private void Start() {
        
        slider.maxValue = playerState.SetMaxHealth();
    }

    private void Update() {
        
        slider.value = playerState.SetcurrentHealth();
    }
}
