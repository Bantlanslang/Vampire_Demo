using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupExp : MonoBehaviour
{
    public ObjectItem gem;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Destroy(gameObject);
            Expup();
        }
    }

    void Expup(){

        PlayerState playerState = FindObjectOfType<PlayerState>();
        playerState.Experience += gem.exp;
    }
}
