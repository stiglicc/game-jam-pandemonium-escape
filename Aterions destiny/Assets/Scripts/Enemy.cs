using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator anima;

    
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        anima.SetTrigger("Hurt");
        
        if (currentHealth <= 0) {
            Die();
        }
    }
    void Die()
    {
        anima.SetBool("isDead",true);
        Debug.Log("Died");
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
