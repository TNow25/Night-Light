using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signScript : MonoBehaviour
{

    public GameObject txtToDisplay;

    private bool PlayerInZone;

    //public GameObject toggleObject;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerInZone = false;
        txtToDisplay.SetActive(false);
        //toggleObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            txtToDisplay.SetActive(true);
            //PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}
