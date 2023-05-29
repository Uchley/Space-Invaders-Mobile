using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{

    public GameObject EnemyProjectile;
    public float SpawnTime;
    public float SpawnMax = 10;
    public float SpawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
       SpawnTime = Random.Range(SpawnMin, SpawnMax); 
    }

    // Update is called once per frame
    void Update()
    {

        SpawnTime -= Time.deltaTime;
        if(SpawnTime <=0)
        {
        Instantiate(EnemyProjectile, transform.position, Quaternion.identity);
        SpawnTime = Random.Range(SpawnMin, SpawnMax); 
        }
    }
}
