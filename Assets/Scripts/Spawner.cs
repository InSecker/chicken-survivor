using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObjPrefabs;

    public float Intervalle = 1;
    float TempsPasse = 0;

    public int Min = -1;
    public int Max = 2;

    // Update is called once per frame
    void Update()
    {
        TempsPasse += Time.deltaTime;

        if (TempsPasse > Intervalle) {

            int index = Random.Range(0, ObjPrefabs.Length);

            GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);

            Vector3 spawnerPos = transform.position;

            spawnerPos.x += Random.Range(Min, Max);

            spawnee.transform.position = spawnerPos;

            TempsPasse = 0;
        }
    }
}
