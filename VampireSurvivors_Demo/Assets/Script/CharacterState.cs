using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterState : MonoBehaviour,IDamageable
{
    [SerializeField]protected float MaxHealth;
    [SerializeField]protected float currentHealth;
    public bool isDead;
    public event Action OnDeath;
    public GameObject enemyFx;


    protected virtual void Start() {

        currentHealth = MaxHealth;    
    }

    public void Dead(){

        isDead = true;
        Destroy(gameObject);

        if(OnDeath != null){
            OnDeath();
        }
    }

    public void TakeDamage(float _DamageAmount)
    {
        currentHealth -= _DamageAmount;
        if(currentHealth <= 0 && isDead == false){
            Dead();
        }
    }
    
}
