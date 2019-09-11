using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarActions : MonoBehaviour
{
    bool canJump = true;

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
