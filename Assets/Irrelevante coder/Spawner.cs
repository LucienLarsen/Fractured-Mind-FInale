using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();
    public List<GameObject> spawnLocationList = new List<GameObject>();
    public GameObject enemyGO;

    public Vector3 spawnPosition;
    public int index = 0;

    public object SpawnLocationlist { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
        SpawnAtLocation();

        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnEnemies();
        }
    }
    private void SpawnWithForLoop()
    {

        for (int i = 0; i < spawnLocationList.Count; i++)
            Instantiate(enemyGO, spawnLocationList[i].transform.position, spawnLocationList[i].transform.rotation);
    }
    private void SpawnEnemies ()
    {
        if (enemiesList.Count > 0)
        {
            index = Random.Range(0, enemiesList.Count);
            spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-20, 20), Random.Range(-2, 2));
            Instantiate(enemiesList[index], spawnPosition, enemiesList[index].transform.rotation);
            enemiesList.Remove(enemiesList[index]);
        }
        else
        {
            Debug.Log("Done spawning enemies");
        }
    }
    private void SpawnAtLocation()
    {
        if (spawnLocationList.Count > 0)
        {
            index = Random.Range(0, spawnLocationList.Count);
            GameObject enemy = Instantiate(enemyGO, spawnLocationList[index].transform.position, spawnLocationList[index].transform.rotation);
            Destroy(spawnLocationList[index]);
            spawnLocationList.Remove(spawnLocationList[index]);
        }
        else
        {
            Debug.Log("Done spawning enemies");
        }
    }

}
