using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : CharacterState
{

    public float Experience = 0;
    public float Experiencelimit = 10;
    public float Level = 0;

    protected override void Start()
    {
        base.Start();
    }
    
    private void OnTriggerStay2D(Collider2D collider) {
        if(collider.CompareTag("Enemy")){
            TakeDamage(collider.GetComponent<EnemyState>().AttackAmount);
        }
    }

    public float SetcurrentHealth(){

        return currentHealth;
    }
    public float SetMaxHealth(){
        
        return MaxHealth;
    }
}
