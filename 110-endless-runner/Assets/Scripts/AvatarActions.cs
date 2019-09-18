using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarActions : MonoBehaviour
{
    bool canJump = true;
    public Text scoreText;
    public static int score;
    public static bool playerAlive = true;

    void Start()
    {
        InvokeRepeating("UpdateScore", 0f, 1f);
    }

    void UpdateScore ()
    {
       if (AvatarActions.playerAlive)
       {
            score++;
            scoreText.text = "Score: " + score;
       }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
        {
            if (canJump)
            {
                canJump = false;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 17), ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump |= collision.gameObject.tag == "Ground";

        //short hand for.
        /*if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }*/
    }
}
