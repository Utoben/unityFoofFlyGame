using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

  
    void Start()
    {

    }

    void FixedUpdate()
    {
        // Получаем пользовательскую вертикальную ось
        verticalInput = Input.GetAxis("Vetical");

        // Двигаем самолёт вперёд
        transform.Translate(Vector3.back * speed);

        // Крутим самолёт вверх/вниз, нажимая на соответствующие клавиши
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
