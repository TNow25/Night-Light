using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class machineScript : MonoBehaviour
{
    public int sceneCounter;
    private bool PlayerInZone;
    public bool canProceed;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInZone = true;
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();
        if(inventory.NumberOfItems >= 20)
        {
            canProceed = true;
        }

    }

    void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E) && canProceed == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(sceneCounter);
        }
    }

}
