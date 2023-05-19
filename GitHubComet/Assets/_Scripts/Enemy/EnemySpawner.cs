using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRate = 1f;

    [SerializeField]
    private GameObject[] enemyPrefabs;

    [SerializeField]
    private bool canSpawn = true;

    public int enemyCount = 0;

    public float ySpawnPositin;
    

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);


        while (canSpawn)
        {
            ySpawnPositin = Random.Range(-3, 3);


            //pause every time wait
            yield return wait;

            int num = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSawn = enemyPrefabs[num];

            Instantiate(enemyToSawn, new Vector2(30, ySpawnPositin), Quaternion.identity);
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }   
    }
}
