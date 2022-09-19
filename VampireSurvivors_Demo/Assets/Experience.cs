using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experience : MonoBehaviour
{
    public Slider slider;
    public Text LevelNum;
    private int LevelCount = 2;
    PlayerInventory playerInventory;

    PlayerState playerState;
    private void Awake() {

        slider = GetComponentInChildren<Slider>();
        LevelNum = GetComponentInChildren<Text>();
        playerState = FindObjectOfType<PlayerState>();
        playerInventory = FindObjectOfType<PlayerInventory>();
    }
    private void Start() {
        
    }
    private void Update() {
        
        slider.maxValue = playerState.Experiencelimit;
        slider.value = playerState.Experience;
        LevelUP();
        LevelNum.text = playerState.Level.ToString();
    }
    void LevelUP(){
        if(slider.value >= slider.maxValue){
            playerState.Level++;
            playerState.Experience = 0;
            playerState.Experiencelimit = (playerState.Experiencelimit + (playerState.Level*2));
            if(playerState.Level >= LevelCount){
                SkillUp();
                LevelCount = LevelCount * 2;
            }
        }
    }
    void SkillUp(){

        foreach (var item in playerInventory.weaponItems)
        {
            if(item.ItemName == "Point"){
                item.bulletAmount++;
            }
        }
    }
}
