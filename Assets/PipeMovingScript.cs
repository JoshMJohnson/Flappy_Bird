using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20;
        deadZone = -40;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
