using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private PlayerInput pi;

    private void Awake() {
        
        anim = GetComponent<Animator>();
        pi = GetComponentInParent<PlayerInput>();
    }

    private void Update() {
        
        anim.SetFloat("forward",pi.Horizontal);
        anim.SetFloat("right",pi.Vertical);
    }
}
