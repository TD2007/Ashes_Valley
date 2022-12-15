using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : CharacterStats
{
    // Start is called before the first frame update
    public HealthBar healthBar;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        healthBar.SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)) {
            TakeDamage(50);
        }
        if(isDeath) {
            anim.SetBool("IsDeath", true);
        }
    }

}
