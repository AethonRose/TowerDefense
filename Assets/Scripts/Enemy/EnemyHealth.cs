using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] int currentHealth = 0;
    [SerializeField] int damage = 10;
    
    void Start() 
    {
        //Set currentHealth = maxHealth
        currentHealth = maxHealth;
    }

    void OnParticleCollision(GameObject other) 
    {
        //Call ProcessHit
        ProcessHit();
    }

    void ProcessHit()
    {
        //Update currentHealth by subtracting damage
        currentHealth -= damage;
        //If currentHealth < 1, Call KillEnemy
        if (currentHealth <= 0)
        {
            KillEnemy();
        }
    }

    void KillEnemy()
    {
        //Destroy this gameObject
        Destroy(this.gameObject);
    }
}
