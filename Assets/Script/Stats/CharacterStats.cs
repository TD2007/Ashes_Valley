using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    // Health
	public int maxHealth;
	public int currentHealth;

	public bool isDeath = false;
	public Stat damage;

	// Set current health to max health
	// when starting the game.
	void Awake ()
	{
		currentHealth = maxHealth;
		
	}

	void Start() {

	}

	// Damage the character
	public void TakeDamage (int damage)
	{
		// Damage the character
		currentHealth -= damage;

		// If health reaches zero
		if (currentHealth <= 0)
		{
			isDeath = true;
		}
	}

	public virtual void Die ()
	{
		// Die in some way
		

	}
}
