using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject fallingPrefab;
    public float spawnRate = 5f;

    private float topY;
    private float leftX;
    private float rightX;

    void Start()
    {
        // Screen bounds in world space
        Camera cam = Camera.main;

        topY = cam.ViewportToWorldPoint(new Vector3(0, 1, 0)).y + 1f;
        leftX = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightX = cam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        InvokeRepeating(nameof(SpawnObject), 1f, spawnRate);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(leftX, rightX);
        Vector3 spawnPos = new Vector3(randomX, topY, 0f);

        Instantiate(fallingPrefab, spawnPos, Quaternion.identity);
    }
}


