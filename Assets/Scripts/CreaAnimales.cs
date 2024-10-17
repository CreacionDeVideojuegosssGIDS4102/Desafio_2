using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Nombre: Mario Alberto Rangel Márquez
Descripcion: Desafio 2
Fecha 16/02/2024
*/
public class CreaAnimales : MonoBehaviour
{
    public GameObject[] animales;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 1, 2);
        InvokeRepeating("SpawnLeftAnimal", 1, 2);
        InvokeRepeating("SpawnRightAnimal", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimal()
    {
        int ind = Random.Range(0, animales.Length);
        int z = Random.Range(-20, 20);
        Vector3 posz = new Vector3(0, animales[ind].transform.position.y, z);

        Instantiate(animales[ind], posz, animales[ind].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
        int ind = Random.Range(0, animales.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animales[ind], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int ind = Random.Range(0, animales.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animales[ind], spawnPos, Quaternion.Euler(rotation));
    }
}
