using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject currentTarget;
    public float Attackdistance = 5.0f;
    
    private void Awake() {
        if(instance != null){
            Destroy(gameObject);
        }
        instance = this;
    }
}
