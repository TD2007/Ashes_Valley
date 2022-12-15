using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : CharacterStats
{
    // Start is called before the first frame update
    public HealthBar healthBar;
    StaminaBar staminaBar;

    public int maxStamina = 200;
    public int currentStamina;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        healthBar.SetHealth(maxHealth);
        // staminaBar.SetMaxStamina(maxStamina);
        currentStamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);

        if(Input.GetKeyDown(KeyCode.M)) {
            ReduceStamina(100);
        }

        // RestoreStamina(1);
        if(isDeath) {
            anim.SetBool("IsDeath", true);
        }
    }

    void ReduceStamina(int stamina) {
        if(currentStamina > stamina) {
            currentStamina -= stamina;
        }
    }

    void RestoreStamina(int stamina) {
        if(currentStamina < maxStamina) {
            currentStamina += stamina;
        }
        // staminaBar.SetStamina(currentStamina);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            TakeDamage(10);
        }

    }

}
