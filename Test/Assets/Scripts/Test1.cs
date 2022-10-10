using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public GameObject[] randomObjects;
    // Start is called before the first frame update
    void SpawnRandomObject()
    {
        int objectIndex = Random.Range(0, 3);
        Instantiate(randomObjects[objectIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
