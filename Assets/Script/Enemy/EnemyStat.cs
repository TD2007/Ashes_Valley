using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : CharacterStats
{
    // Start is called before the first frame update
    Animator anim;

    public PlayerStat playerStat;

    void Start()
    {
        anim = GetComponent<Animator>();

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

    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "WeaponPlayer") {
            TakeDamage(playerStat.attackDamage);
        }

    }
}
