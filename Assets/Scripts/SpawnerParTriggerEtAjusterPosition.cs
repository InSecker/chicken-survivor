using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerParTriggerEtAjusterPosition : MonoBehaviour
{
    public GameObject[] ObjPrefabs;

    public int Min = -1;
    public int Max = 2;

    private GameObject LastSpawnee;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPrefab();
    }

    public void SpawnPrefab() {
        int index = Random.Range(0, ObjPrefabs.Length);

        GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);

        if (LastSpawnee != null) {
            Vector3 lastSpawneePos = LastSpawnee.transform.position;

            // Modifier cette pos par le longer du dernier spawnee
            BoxCollider coll = LastSpawnee.GetComponent<BoxCollider>();
            lastSpawneePos.z += coll.bounds.size.z;

            spawnee.transform.position = lastSpawneePos;

        } else {
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += Random.Range(Min, Max);
            spawnee.transform.position = spawnerPos;
        }

        LastSpawnee = spawnee;
    }
}
