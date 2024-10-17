using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre: Mario Alberto Rangel Márquez
Descripcion: Desafio 2
Fecha 16/02/2024
*/
public class DetectaColicion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Si colisiona con el jugador, muestra "Game Over"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else
        {
            // Si no es el jugador, destruye ambos objetos en la colisión
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
