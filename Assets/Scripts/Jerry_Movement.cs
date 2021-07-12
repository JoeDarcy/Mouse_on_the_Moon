using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerry_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D jerryRb = null;
    [SerializeField] private float thrust = 10.0f;
    [SerializeField] private float horizontalMovement = 0.0f;
    private Vector3 movementVec = new Vector3 (0, 0);
    private bool spacebarHeld = false;
    private bool horizontalMovementRightHeld = false;
    private bool horizontalMovementLeftHeld = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update movement vector with increased or reset thrust
        movementVec = new Vector3(horizontalMovement, thrust);

        // Apply thrust to Jerry if space bar is held down
        if (Input.GetKey("space")) {
            spacebarHeld = true;
            Debug.Log("Space was pressed");
            jerryRb.MovePosition(transform.position + movementVec);
            if (thrust < 0.5) {
                thrust += 0.001f;        // Increment thrust a little each frame for acceleration
            }
        }

        // Reset thrust after spacebar is released
        if (Input.GetKeyUp("space")) {
            spacebarHeld = false;           
        }

        // Decceleration when spacebar is released
        if (spacebarHeld == false && thrust > 0.0f) {
            thrust -= 0.01f;        // Decrement thrust a little each frame for decceleration
        }

        // Horizontal movement with 'a', 'd', left and right arrows
        if (Input.GetKey("a")) {
            horizontalMovementRightHeld = true;
            horizontalMovement = -0.1f;
            jerryRb.MovePosition(transform.position + movementVec);
            movementVec = new Vector3(horizontalMovement, thrust);
        }

        if (Input.GetKey("d")) {
            horizontalMovementLeftHeld = true;
            horizontalMovement = 0.1f;
            jerryRb.MovePosition(transform.position + movementVec);
            movementVec = new Vector3(horizontalMovement, thrust);
        }

        // Reset horizontal movement after 'a', 'd', left or right arrows are released

        // Right horizontal movement
        if (Input.GetKeyUp("d")) {
            horizontalMovementRightHeld = false;
        }

        if (horizontalMovementRightHeld == false && horizontalMovement > 0) {
            horizontalMovement -= 0.01f;
		}

        // Left horizontal movement
        if (Input.GetKeyUp("a")) {
            horizontalMovementLeftHeld = false;
        }

        if (horizontalMovementLeftHeld == false && horizontalMovement < 0) {
            horizontalMovement += 0.01f;
        }
    }
}
