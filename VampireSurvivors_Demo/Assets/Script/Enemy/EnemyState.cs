using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyState : CharacterState
{
    [SerializeField]private Transform target;
    private Rigidbody2D rigid;
    public int AttackAmount = 1;

    protected override void Start() {
        base.Start();
        if(GameObject.FindGameObjectWithTag("Player") != null){
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        
        Trace();
    }

    private void Trace(){
        if(target != null){
            this.transform.position = Vector2.MoveTowards(this.transform.position,target.transform.position,2.0f * Time.deltaTime);
        }
    }
}
