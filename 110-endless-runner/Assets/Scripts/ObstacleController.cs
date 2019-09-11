using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float objectSpeed = 5f;

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * objectSpeed;

        if (transform.position.x < -10)
        {
            Object.Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Bam!");
        Object.Destroy(gameObject);
    }
}
