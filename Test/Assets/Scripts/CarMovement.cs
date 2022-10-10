using System.Collections;

using System.Collections.Generic;
using UnityEngine;


public class CarMovement : MonoBehaviour
{
    public float speed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))


            transform.Translate(Vector3.forward * Time.deltaTime * speed);




        //if (Input.GetKey(KeyCode.A))
           // transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime * speed);
    }

    

}
