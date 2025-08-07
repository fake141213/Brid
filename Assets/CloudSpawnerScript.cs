using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject Cloud;
    public float spawnRate = 4f;
    private float timer = 0f;
    public float heightOffset = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnCloud();
            timer = 0f;
        }
    }
    void SpawnCloud()
    {
        float minY = transform.position.y - heightOffset;
        float maxY = transform.position.y + heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(minY, maxY), 0);
        GameObject newCloud = Instantiate(Cloud, spawnPosition, Quaternion.identity);
    }

    
}
