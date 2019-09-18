using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalValues : MonoBehaviour
{
    public static float gameSpeed = 2f;

    void Update()
    {
        gameSpeed += Time.deltaTime / 4;   
    }
}
