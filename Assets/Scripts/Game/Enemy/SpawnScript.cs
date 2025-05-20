using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    //public Transform SpawnPoint;
    //public GameObject Prefab;

    public GameObject Enemies;

    // Start is called before the first frame update
    void Start()
    {
        Enemies.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);
        Enemies.SetActive(true);
    }

}
