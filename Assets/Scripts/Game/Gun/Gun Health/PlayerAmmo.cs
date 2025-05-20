using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAmmo : MonoBehaviour
{
    public int ammoCounter = 31;
    public bool death;
    //this means the integer can be retrieved from other scripts but cant be changed by anything other than this script

    public UnityEvent<PlayerAmmo> OnPlayerShot;

    public void playerShot()
    {
        //Debug.Log("player hit");


        ammoCounter--;

        OnPlayerShot.Invoke(this);

        if(ammoCounter < 0)
        {
            ammoCounter = 0;
        }
    }

    public void playerReload()
    {
        ammoCounter = 31; 
        
    }

}
