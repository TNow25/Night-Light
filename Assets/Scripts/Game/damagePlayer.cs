using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class damagePlayer : MonoBehaviour
{
    public int playerHealth = 100;


    public int damage = 10;

    public int sceneCounter;

    public bool dead;
    public int hitCounter = 0;  

    //public FirstPersonPlayer firstPerson;

    //public GameObject gameOverText;


    /*
    public int healthRemaining { get; private set; }
    //this means the integer can be retrieved from other scripts but cant be changed by anything other than this script

    public UnityEvent<damagePlayer> onPlayerHit;

    public void playerHit()
    {
        healthRemaining = healthRemaining - damage;
        onPlayerHit.Invoke(this);
    }
    */

    void Start()
    {
        //PlayerHealth playerHit = GetComponent<PlayerHealth>();
        //gameOverText = GetComponent<TextMeshProUGUI>();
        //gameOverText.SetActive(false);
        Debug.Log(playerHealth);
    }



    private void OnColliderEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            playerHealth = playerHealth - damage;
            Debug.Log("Damage taken");


            PlayerHealth playerHit = collision.GetComponent<PlayerHealth>();

            if (playerHit != null)
            {
                //Debug.Log("player hit");
                playerHit.playerHit();
                hitCounter++;
                //gameObject.SetActive(false);
            }


            if (playerHealth <= 0)
            {
                //Destroy(gameObject);
                //gameOverText.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(sceneCounter);
            }

        }
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if (playerHealth <= 0)
            {
                //Destroy(gameObject);
                //gameOverText.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(sceneCounter);
            }
        }

        PlayerHealth playerHit = collision.GetComponent<PlayerHealth>();

        if (playerHit != null)
        {
            //Debug.Log("player hit");
            playerHit.playerHit();
            hitCounter++;
        }
            //string playerHitString = playerHit.healthCounter.ToString();

            /*if (playerHit.death == true)
            {
                //Destroy(gameObject);
                //gameOverText.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(sceneCounter);
            }
            //gameObject.SetActive(false);
        }
        
        if (playerHealth <= 0)
        {
            //Destroy(gameObject);
            //gameOverText.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(sceneCounter);
        }
        */
    }

    /*
    void Update()
    {
        //PlayerHealth playerHit = GetComponent<PlayerHealth>();
        
        if (hitCounter == 10)
        {
            //Destroy(gameObject);
            //gameOverText.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(sceneCounter);
        }
    }*/

}
