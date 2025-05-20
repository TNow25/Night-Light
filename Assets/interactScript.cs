using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactScript : MonoBehaviour
{
    [SerializeField] private KeyCode interactKey = KeyCode.E;
    public GameObject cylinder;
    public bool EPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        cylinder.SetActive(false);
        EPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(interactKey))
        {
            EPressed = true;
            cylinder.SetActive(true);
        }
        //interactOff();
    }

    public void interact()
    {
        EPressed = true;
    }

    public void interactOff()
    {
        EPressed = false;
    }

}
