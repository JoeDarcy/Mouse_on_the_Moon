using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust_Bar : MonoBehaviour
{
    [SerializeField] private float thrustY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x, thrustY, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        thrustY = Jerry_Movement.thrustToBar * 10;
        transform.localScale = new Vector3(transform.localScale.x, thrustY, transform.localScale.z);
    }
}
