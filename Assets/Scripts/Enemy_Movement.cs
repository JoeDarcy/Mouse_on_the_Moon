using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeedX = 0.01f;
    [SerializeField] private float moveSpeedY = 0.01f;
    [SerializeField] private GameObject bird = null;
    [SerializeField] private float rightBounds = 8.0f;
    [SerializeField] private float leftBounds = -8.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBounds || transform.position.x < leftBounds) {
            Destroy(bird);
		}

        transform.position = new Vector3(transform.position.x + moveSpeedX, transform.position.y + moveSpeedY, transform.position.z);
    }
}
