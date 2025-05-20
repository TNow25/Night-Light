using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfItems { get; private set; }
    //this means the integer can be retrieved from other scripts but cant be changed by anything other than this script

    public UnityEvent<PlayerInventory> OnItemCollected;

    public void itemCollected()
    {
        NumberOfItems++;
        OnItemCollected.Invoke(this);
    }
}

