using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();

        if(inventory != null)
        {
            inventory.itemCollected();
            gameObject.SetActive(false);
        }

    }
}
