using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeedX = 0.01f;
    [SerializeField] private float moveSpeedY = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + moveSpeedX, transform.position.y + moveSpeedY, transform.position.z);
    }
}
