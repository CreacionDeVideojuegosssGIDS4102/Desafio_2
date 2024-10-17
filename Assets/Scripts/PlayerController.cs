using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre: Mario Alberto Rangel Márquez
Descripcion: Desafio 2
Fecha 16/02/2024
*/
public class PlayerController : MonoBehaviour
{
    public GameObject proyectil;
    public Transform projectileSpawnPoint; // Punto de generación para el proyectil
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zMin = -14.0f;
    public float zMax = 34.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Limitar movimiento en eje X
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Limitar movimiento en eje Z
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        // Movimiento horizontal y vertical
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Disparo del proyectil al presionar espacio, usando el punto de generación
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectil, projectileSpawnPoint.position, proyectil.transform.rotation);
        }
    }
}
