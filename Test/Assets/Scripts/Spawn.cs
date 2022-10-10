using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] animals;
    
    public GameObject prefab;/// <summary>
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animals[0], animals[0].transform.position, animals[0].transform.rotation);
            Instantiate(animals[1], animals[1].transform.position, animals[1].transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))///////
            Instantiate(prefab, transform.position, prefab.transform.rotation);
    }
}
