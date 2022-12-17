using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : CharacterStats
{
    // Start is called before the first frame update
    Animator anim;

    PlayerStat playerStat;
    public bool isEnemyAttack = false;

    BoxCollider box;
    void Start()
    {
        anim = GetComponent<Animator>();
        box = GameObject.FindGameObjectWithTag("Enemy").GetComponent<BoxCollider>();
        box.enabled = !box.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDeath) {
            anim.SetBool("isAttacking", false);
            anim.SetBool("isChasing", false);
            anim.SetBool("isPatrolling", false);
            anim.SetBool("isDeath", true);
        }

        CheckAttackState();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "WeaponPlayer") {
            TakeDamage(10);
        }

    }

    void CheckAttackState() {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")) {
            isEnemyAttack = true;
        }
        else {
            isEnemyAttack = false;
        }
    }
}
