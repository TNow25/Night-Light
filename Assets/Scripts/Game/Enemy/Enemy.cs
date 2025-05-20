using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour, IDamageable
{
    private float health = 100f;

    private NavMeshAgent agent;
    public Transform player;
    public int sceneCounter;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = player.position;
    }


    public void TakeDamage(float damage)
    {
        Debug.Log("Enemy Taken Damage");
        health -= damage;
        
        if (health <= 0)
        {
            Debug.Log("Enemy destroyed");
            Destroy(gameObject);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHit = other.GetComponent<PlayerHealth>();

        if (playerHit != null)
        {
            playerHit.playerHit();
            Debug.Log("player hit by enemy");

            if (playerHit.death == true)
            {
                //Destroy(gameObject);
                //gameOverText.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(sceneCounter);
            }

            //gameObject.SetActive(false);
        }
    }

}
