using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject SpawnPrefabEnemy;
    public GameObject SpawnPrefabReward;
    private float minX = -13.0f;
    private float maxX = 13.0f;
    private float speedReward = 2;
    private float speedEnemy = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnEnemy", 1.5f, speedEnemy);
        InvokeRepeating("spawnRewards", 1, speedReward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnemy()
    {
        float xValue = Random.Range(minX, maxX);
        Instantiate(SpawnPrefabEnemy, new Vector3(xValue, 15, 0), SpawnPrefabEnemy.transform.rotation);
    }

    private void spawnRewards()
    {
        float xValue = Random.Range(minX, maxX);
        Instantiate(SpawnPrefabReward, new Vector3(xValue, 15, 0), SpawnPrefabEnemy.transform.rotation);
    
    }
}
