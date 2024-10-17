using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre: Mario Alberto Rangel Márquez
Descripcion: Desafio 2
Fecha 16/02/2024
*/
public class Move : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Si el objeto sale de los límites en el eje Z (superior o inferior)
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        // Si el objeto sale de los límites en el eje X (lados)
        else if (transform.position.x > sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
    }
}
