using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Button : MonoBehaviour
{
    public GameObject antiNavSpace;
    public NavMeshSurface navSurface;
    private interactScript interactScript;

    public bool interactPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        antiNavSpace.SetActive(false);
        interactScript = antiNavSpace.GetComponent<interactScript>();
    }

    void Update()
    {
        interactPressed = interactScript;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(interactPressed == true)
            {
                antiNavSpace.SetActive(true);
            }
            else
            {
                antiNavSpace.SetActive(false);
            }

            //navSurface.BuildNavMesh();
        }

    }


}
