using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Map : MonoBehaviour
{
    private float startYPos = -5.5f;
    private float endYPos = 0.0f;   
    [SerializeField] private float yPos = -5.5f;
    [SerializeField] private float miniMapSpeed = 1.0f;
    public static bool miniMapMovement = false;

    // Start is called before the first frame update
    void Start()
    {

        transform.localPosition = new Vector3(transform.localPosition.x, startYPos, transform.localPosition.z);

    }

    // Update is called once per frame
    void Update()
    {

        if (miniMapMovement == true) {
            yPos = transform.localPosition.y + miniMapSpeed * Time.deltaTime;
        } else {
            yPos = transform.localPosition.y - miniMapSpeed * Time.deltaTime;
        }

        transform.localPosition = new Vector3(transform.localPosition.x, yPos, transform.localPosition.z);

        // Bound yPos
        if (yPos < startYPos) {
            yPos = startYPos;
            transform.localPosition = new Vector3(transform.localPosition.x, yPos, transform.localPosition.z);
		} else if (yPos > endYPos) {
            yPos = endYPos;
            transform.localPosition = new Vector3(transform.localPosition.x, yPos, transform.localPosition.z);
        }
    }
}
