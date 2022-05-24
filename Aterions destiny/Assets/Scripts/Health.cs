using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int damage;
    public int healAmount;
    Animator anima;

    public healthBar healthBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap") {
            currentHealth -= damage;
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
    }
    private void Update()
    {
        if (currentHealth <= 0) {
            anima.Play("Dead");
            GetComponent<playerMovement>().enabled = false;
            Invoke("reloadLevel",2f);
        }
    }
    void reloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
