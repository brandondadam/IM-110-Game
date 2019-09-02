using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float backgroundSpeed = -5f;
    public GameObject otherBackground;

    void Update()
    {
        transform.position += new Vector3(backgroundSpeed * Time.deltaTime, 0, 0);
    }

    void LateUpdate()
    {
        if (transform.position.x <= -22)
        {
            float halfOtherBackgroundWidth = otherBackground.GetComponent<SpriteRenderer>().bounds.extents.x;
            float halfThisBackgroundWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

            float newXPosition = otherBackground.transform.position.x + halfOtherBackgroundWidth + halfThisBackgroundWidth;
            newXPosition -= .25f;

            transform.position = new Vector3(newXPosition, otherBackground.transform.position.y);
        }
    }
}
