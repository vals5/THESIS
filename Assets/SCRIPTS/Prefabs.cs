using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs : MonoBehaviour
{
    public GameObject[] platforms;
    public GameObject[] floor;
    public float xSpawn = 0;
    public float prefabLength = 3;
    public int numberOfPrefabs = 4;
    private List<GameObject> activePrefabs = new List<GameObject>();

    public Transform player;
    void Start()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            if (i == 0)
                SpawnPrefab(0);
            else
                SpawnPrefab(Random.Range(0, platforms.Length));
        }
    }   
    void Update()
    {
        if (player.position.x - 30 > xSpawn - (numberOfPrefabs  * prefabLength))
        {
            SpawnPrefab(Random.Range(0, platforms.Length));
            DeletePrefab();
        }
    }
    public void SpawnPrefab(int prefabIndex)
    {
        GameObject go = Instantiate(platforms[prefabIndex], transform.right * xSpawn, transform.rotation);
        activePrefabs.Add(go);

        xSpawn += prefabLength;
    }
    private void DeletePrefab()
    {
        Destroy(activePrefabs[0]);
        activePrefabs.RemoveAt(0);
    }
}

