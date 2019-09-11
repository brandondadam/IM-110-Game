using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
	public GameObject obstaclePrefab;

    void Start()
    {
		InvokeRepeating("CreateObstacle", 0.5f, 2.0f);
    }

    void CreateObstacle ()
    {
        GameObject obj = Instantiate(obstaclePrefab, transform);
		obj.transform.position = new Vector3(9f, -3f, -1f);
	}
}
