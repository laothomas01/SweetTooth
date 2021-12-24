using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Attributes : MonoBehaviour
{


    public int maxHealth = 10;
    public int currentHealth = 0;
    private Vector2 currentPosition;
    Animator animator;
    private bool playerIsDead = false;
    private bool isInvincible = false;
    [SerializeField] private float iFramesDuration;


    void Start()
    {

        currentHealth = maxHealth;
        currentPosition = this.transform.position;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    //player takes damage
    public void TakeDamage(int damage)
    {

        currentHealth -= damage;


        if (currentHealth <= 0)
        {
            currentHealth = 0;
            playerIsDead = true;
            Die();
        }
    }
    //player heals health
    public void Health(int heal)
    {
        if (playerIsDead)
        {
            return;
        }
        else if (currentHealth > 0 && currentHealth < maxHealth)
        {
            currentHealth += heal;

        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

    }

    void Die()
    {
        GetComponent<PlayerController>().enabled = false;
        this.GetComponentInChildren<Gun>().enabled = false;
        //this.enabled = false;
        Debug.Log("You are Dead");



    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public IEnumerator Invunerability()
    {

        Debug.Log("Player turned invincible!");
        isInvincible = true;


        yield return new WaitForSeconds(iFramesDuration);



        isInvincible = false;
        Debug.Log("Player no longer invincible!");

    }
}