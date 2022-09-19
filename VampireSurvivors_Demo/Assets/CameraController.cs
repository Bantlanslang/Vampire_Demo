using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject target;
    private void Awake() {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update() {
        if(target != null){
            transform.position = new Vector3(target.transform.position.x,target.transform.position.y,-10);
        }
    }

}
