using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    private Animator anim;
    float playerHeight = 2;
     bool grounded;

    public LayerMask whatIsGround;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.Raycast(player.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);
        Move();
        Attack();
        // CheckAttackState();

    }

    void Move() {
        // if(Input.GetKeyDown(KeyCode.Space) && grounded) {
        //     anim.SetBool("IsJump", true);
        // }
        // else {
        //     anim.SetBool("IsJump", false);
        // }
        
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            anim.SetFloat("Speed", 0.5f);
            if(Input.GetKey(KeyCode.LeftShift)) {
                anim.SetFloat("Speed", 1.0f);
            }
        }
        else {
            anim.SetFloat("Speed", 0.0f);
        }
       
        
    }

    void Attack() {
        if(Input.GetKey(KeyCode.F)) {
            anim.SetBool("LevelUp", true);
        }
        else {
            anim.SetBool("LevelUp", false);
        }
        // Spin Attack
        if(Input.GetKey(KeyCode.Mouse0) && Input.GetKey(KeyCode.Mouse1)) {
            anim.SetBool("SpinAttack", true);
        }
        else {
            anim.SetBool("SpinAttack", false);
            // if(Input.GetKey(KeyCode.Mouse0)) {
            //     if(anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack1")) {
            //         anim.SetBool("LightAttack2", true);
            //     }
            //     else {
            //         anim.SetBool("LightAttack1", true);
            //     }
            // }
            // Heavy Attack
            if(Input.GetKey(KeyCode.Mouse1)) {
                anim.SetBool("HeavyAttack", true);
            }
            else {
                anim.SetBool("HeavyAttack", false);
            }
        }
        
    }

    // void CheckAttackState() {
    //     if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack1")) {
    //         anim.SetBool("LightAttack1", false);
    //     }
    //     if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5f && anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack2")) {
    //         anim.SetBool("LightAttack2", false);
    //     }
    // }



}
