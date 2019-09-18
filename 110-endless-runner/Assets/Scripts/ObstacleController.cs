using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speedAdjustment = 1f;
    bool dodgedEnemy = false;

    void Update()
    {

        if (AvatarActions.playerAlive)
        {
            transform.position += Vector3.left * Time.deltaTime * (GlobalValues.gameSpeed + speedAdjustment);
        }

        if (transform.position.x <= -7.5f && !dodgedEnemy)
        {
            dodgedEnemy = true;
            AvatarActions.score += 10;
        }

        if (transform.position.x < -10)
        {
            Object.Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Bam!");
        Object.Destroy(gameObject);
        AvatarActions.playerAlive = false;
    }
}
