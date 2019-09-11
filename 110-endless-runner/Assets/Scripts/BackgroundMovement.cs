using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float backgroundSpeed = -2f;
    public GameObject otherBackground;

    public int showBackground1 = 25;
    public int showBackground2 = 25;
    public int showBackground3 = 25;
    public int showBackground4 = 25;


    void Update()
    {
        transform.position += new Vector3(backgroundSpeed * Time.deltaTime, 0, 0);
    }

    void LateUpdate()
    {
        if (transform.position.x <= -22)
        {
            ChangeBackgroundArt();

            float halfOtherBackgroundWidth = otherBackground.GetComponent<SpriteRenderer>().bounds.extents.x;
            float halfThisBackgroundWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

            float newXPosition = otherBackground.transform.position.x + halfOtherBackgroundWidth + halfThisBackgroundWidth;
            newXPosition -= .25f;

            transform.position = new Vector3(newXPosition, otherBackground.transform.position.y);
        }
    }

    void ChangeBackgroundArt()
    {
        int randomNumber = Random.Range(0, 100);

        if (randomNumber < showBackground1)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile1");
        }
        else  if (randomNumber < showBackground2 + showBackground1)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile2");
        }
        else if (randomNumber < showBackground3 + showBackground2 + showBackground1)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile3");
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile4");
        }
    }
}
