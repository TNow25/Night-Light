using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class switchScript : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool PlayerInZone;

    public GameObject toggleObject;


    public GameObject lightSource;
    public NavMeshSurface navSurface;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone = false;
        txtToDisplay.SetActive(false);
        toggleObject.SetActive(false);
        lightSource.SetActive(false);
        buildNewMesh(); //builds the navmesh with the object being toggled on and off in the correct state, off 
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInZone && Input.GetKeyDown(KeyCode.E))
        {
            toggleObject.SetActive(!toggleObject.activeSelf);
            //used to toggle on or off the game entity selected in inspector

            buildNewMesh();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }

    private void buildNewMesh()
    {
        navSurface.BuildNavMesh();
    }
}
