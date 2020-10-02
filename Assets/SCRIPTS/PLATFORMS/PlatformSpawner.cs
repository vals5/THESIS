using System;
using System.Collections;
using System.Collections.Generic;
using PLATFORMS;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    public Transform player;

    public BasePlatform[] basePlatforms;
    public MovingPlatform[] movingPlatforms;

    [Space(10)]
    [Range(0, 1f)]
    public float movingPlatformSpawnChance = .5f;

    public float aheadOfPlayerSpawningOffset = 3;

    [Space(10)]
    public List<GameObject> activePlatforms = new List<GameObject>();

    public int margin = 1;

    public float distanceUntilNextSpawn = 0;

    void Update()
    {
        if (player.position.x + aheadOfPlayerSpawningOffset > distanceUntilNextSpawn)
        {
            if (Random.value > movingPlatformSpawnChance)
                SpawnPrefab(basePlatforms[Random.Range(0, basePlatforms.Length)]);
            else
                SpawnPrefab(movingPlatforms[Random.Range(0, movingPlatforms.Length)]);

            DeletePrefab();
        }
    }
    public void SpawnPrefab(BasePlatform newPlatform)
    {
        GameObject go = Instantiate(
            newPlatform.prefab,
            transform.position + Vector3.right * (distanceUntilNextSpawn + margin),
            Quaternion.identity,
            transform);

        activePlatforms.Add(go);
        distanceUntilNextSpawn += margin + newPlatform.width;
    }
    private void DeletePrefab()
    {
        Destroy(activePlatforms[0]);
        activePlatforms.RemoveAt(0);
    }
}