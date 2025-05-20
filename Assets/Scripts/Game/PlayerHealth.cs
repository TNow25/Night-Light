using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int healthCounter = 100;
    public bool death;
    //this means the integer can be retrieved from other scripts but cant be changed by anything other than this script

    public UnityEvent<PlayerHealth> OnPlayerHit;

    public void playerHit()
    {
        //Debug.Log("player hit");
        

        healthCounter = healthCounter - 10;

        //Debug.Log(healthCounter);

        //Debug.Log(death);

        OnPlayerHit.Invoke(this);
        
        if(healthCounter <= 0)
        {
            death = true;
        }
    }

}
