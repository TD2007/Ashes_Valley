using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : CharacterStats
{
    // Start is called before the first frame update
    public HealthBar healthBar;
    public StaminaBar staminaBar;

    public int maxStamina = 200;
    public int currentStamina;
    float timer = 0;
    
    Animator anim;
    void Start()
    {
        maxHealth = 100;
        anim = GetComponent<Animator>();
        healthBar.SetHealth(maxHealth);
        staminaBar.SetMaxStamina(maxStamina);
        currentStamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);

        RestoreStamina(1);
        if(isDeath) {
            anim.SetBool("IsDeath", true);
        }
        
        timer += Time.deltaTime;
    }

    public void ReduceStamina(int stamina, float countdown) {
        
        if(currentStamina > stamina & timer > countdown) {
            currentStamina -= stamina;
            timer = 0;
        }
    }

    void RestoreStamina(int stamina) {
        if(currentStamina < maxStamina) {
            currentStamina += stamina;
        }
        staminaBar.SetStamina(currentStamina);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            TakeDamage(10);
        }

    }

}
