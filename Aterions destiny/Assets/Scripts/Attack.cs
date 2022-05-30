using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anima;

    public AudioSource audioS;
    public AudioClip attackSound;

    public Transform attackPoint;
    public Transform attackPoint2;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public float attackRange2 = 0.5f;
    public int attackDamage = 40;
    public float attackCooldown=2f;
    public float nextAttackTime = 0f;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                Attack_();
                nextAttackTime = Time.time + 2f / attackCooldown;
                playSound();
            }
        }
        
        
    }
    private void Attack_(){
            anima.SetTrigger("Attack");

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            Collider2D[] hitEnemiess = Physics2D.OverlapCircleAll(attackPoint2.position, attackRange2, enemyLayers);


        foreach (Collider2D enemy in hitEnemies){
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            Debug.Log("we hit the enemy");   
        }
        foreach (Collider2D enemy in hitEnemiess)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            Debug.Log("we hit the enemy");
        }
    }
    private void OnDrawGizmosSelected(){ 
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        Gizmos.DrawWireSphere(attackPoint2.position, attackRange2);
    }
    
    private void playSound() {
        if (!audioS.isPlaying) {
            audioS.PlayOneShot(attackSound);
            
        }
    }
}

