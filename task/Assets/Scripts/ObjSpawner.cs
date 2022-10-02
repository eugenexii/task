using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject spikePrefab;
    public int n;
    void Awake()
    {
        for (int i=0; i<n; i++)
        {
            Vector2 randomCoinPosition = new Vector2(Random.Range(-3.5f, 3.5f), Random.Range(-5f, 5f));
            Instantiate(coinPrefab, randomCoinPosition, Quaternion.identity);
            Vector2 randomSpikePosition = new Vector2(Random.Range(-3.5f, 3.5f), Random.Range(-5f, 5f));
            Instantiate(spikePrefab, randomSpikePosition, Quaternion.identity);
        }

    }
}
