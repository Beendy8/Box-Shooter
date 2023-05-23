using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyes : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;
    [SerializeField] private int maxX, minX, maxY, minY, maxZ, minZ;
    [SerializeField] private float timerSpawm;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(timerSpawm);
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
            GameObject enemyCube = Instantiate(enemy[Random.Range(0, enemy.Length)], spawnPos, Quaternion.identity);
        }
    }

}

