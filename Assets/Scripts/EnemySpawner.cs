using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer;
    public GameObject enemyPrefab;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5)
        {
            timer = 0;
            //espawnea enemigos en un rango 
            Instantiate(enemyPrefab, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.identity);
        }
    }
}
