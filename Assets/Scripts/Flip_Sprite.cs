using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip_Sprite : MonoBehaviour
{
    private Vector3 previousPosition = new Vector3(0, 0, 0);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (previousPosition.x > transform.position.x) {
            Debug.Log("Moving Left");
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (previousPosition.x < transform.position.x) {
            Debug.Log("Moving RIght");
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        previousPosition = transform.position;


    }
}
