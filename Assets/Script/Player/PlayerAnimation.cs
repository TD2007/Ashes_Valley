using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    float playerHeight = 2;
    bool grounded;

    public LayerMask whatIsGround;
    public Transform player;

    public PlayerStat playerStat;
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
        CheckAttackState();


 
    }

    void Move() {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            anim.SetFloat("Speed", 0.5f);
            if(Input.GetKey(KeyCode.LeftShift)) {
                anim.SetFloat("Speed", 1.0f);
                playerStat.ReduceStamina(2, 0);
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
        if(Input.GetKeyDown(KeyCode.LeftControl)) {
            anim.SetBool("SpinAttack", true);
            playerStat.ReduceStamina(100, 0.5f);
            
        }
        else {
            anim.SetBool("SpinAttack", false);
            // Heavy Attack
            if(Input.GetKeyDown(KeyCode.Mouse1)) {
                anim.SetBool("HeavyAttack", true);
                playerStat.ReduceStamina(50, 1);
            }
            else {
                anim.SetBool("HeavyAttack", false);

                if(Input.GetKeyDown(KeyCode.Mouse0)) {
                    if(anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack1")) {
                        anim.SetBool("LightAttack2", true);
                        playerStat.ReduceStamina(10, 0.2f);
                    }
                    else {
                        anim.SetBool("LightAttack1", true);
                        playerStat.ReduceStamina(10, 0.2f);
                    }

                }
            }
        }
        
    }

    void CheckAttackState() {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.6f && anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack1")) {
            anim.SetBool("LightAttack1", false);
        }
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.6f && anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack2")) {
            anim.SetBool("LightAttack2", false);
        }
    }




}
