using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int damage;
    public int death_damage;
    public int healAmount;
    public AudioClip deathSound;
    public AudioSource audioS;
    Animator anima;
    bool isPlayed;

    public healthBar healthBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap") {
            currentHealth -= damage;
            Debug.Log("You took damage!");
            healthBar.SetHealth(currentHealth);
        }else if ( collision.gameObject.tag == "Death") { 
            currentHealth -= death_damage;
            Debug.Log("You took damage!");
            healthBar.SetHealth(currentHealth);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Potion") {
            currentHealth += healAmount;
            healthBar.SetHealth(currentHealth);
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        anima = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthLimit();
    }
    private void Update()
    {
        if (currentHealth <= 0) {
            playSound();
            anima.Play("Dead");
            GetComponent<playerMovement>().enabled = false;
            Invoke("reloadLevel",2f);
        }
    }
    private void playSound() {
        if (!audioS.isPlaying && !isPlayed){
            audioS.PlayOneShot(deathSound);
            isPlayed=true;
            
        }
    }
    void reloadLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void healthLimit() {
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    }
}
