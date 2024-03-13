using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer;
    public float heightOffset;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 1;
        timer = 0;
        heightOffset = 10;

        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector2(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
