using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rigid;
    [SerializeField]private float walkSpeed = 3.0f;
    private Vector2 moving;
    
    public float Horizontal;
    public float Vertical;



    private void Awake() {

        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        PlayerController();
    }
    private void FixedUpdate() {
        
        rigid.MovePosition(rigid.position + moving * Time.fixedDeltaTime * walkSpeed);
    }

    public void PlayerController(){
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        moving = new Vector2(Horizontal,Vertical);
    }
    
}
