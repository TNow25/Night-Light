using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public static Action shootInput;
    public static Action reloadInput;
    
    [SerializeField] private KeyCode reloadKey = KeyCode.R;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //Debug.Log("Player shot");
            shootInput?.Invoke();
            // "?" is a null conditional operator
            //avoids null pointer exceptions
        }

        if(Input.GetKeyDown(reloadKey))
        {
            reloadInput?.Invoke();
            //Debug.Log("Reload complete?");
        }
    }

}
