using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerry_Movement : MonoBehaviour
{
    // Punblic static variables
    public static float burnRate = 0.1f;
    public static float fallSpeed = 0.01f;

    [SerializeField] private Rigidbody2D jerryRb = null;
    [SerializeField] private float thrust = 10.0f;
    [SerializeField] private float horizontalMovement = 0.0f;
    private Vector3 movementVec = new Vector3 (0, 0, 0);
    private bool spacebarHeld = false;
    private bool horizontalMovementRightHeld = false;
    private bool horizontalMovementLeftHeld = false;
    [SerializeField] private float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate Jerry's air speed
        speed = transform.position.y / Time.time;

        // Update movement vector with increased or reset thrust
        movementVec = new Vector3(horizontalMovement, thrust, 0);

        // Apply thrust to Jerry if space bar is held down
        if (Input.GetKey("space")) {

            spacebarHeld = true;
            Debug.Log("Space was pressed");

            // Check totalFuel is greater than 0.1f and apply thrust to Jerry, (with acceleration)
            if (Fuel_Script.totalFuel > 0.1f) {

                // Decriment totalFuel in the Fuel_Script
                Fuel_Script.totalFuel -= burnRate; //  0.1f;

                // Apply thrust to Jerry
                jerryRb.MovePosition(transform.position + movementVec);
                if (thrust < 0.5) {
                    thrust += 0.001f / 2;        // Increment thrust a little each frame for acceleration
                }
            }
        }

        // Reset thrust after spacebar is released
        if (Input.GetKeyUp("space")) {
            spacebarHeld = false;           
        }

        // Decceleration when spacebar is released
        if (spacebarHeld == false && thrust > 0.0f) {
            thrust -= fallSpeed; //0.01f;  Decrement thrust a little each frame for decceleration

            jerryRb.MovePosition(transform.position + movementVec);
        }

        // Horizontal movement with 'a', 'd', left and right arrows
        if (Input.GetKey("a")) {
            horizontalMovementRightHeld = true;
            horizontalMovement = -0.1f;

            if (Fuel_Script.totalFuel > 0.1f) {
                jerryRb.MovePosition(transform.position + movementVec);
                movementVec = new Vector3(horizontalMovement, thrust);
            }
                
        }

        if (Input.GetKey("d")) {
            horizontalMovementLeftHeld = true;
            horizontalMovement = 0.1f;
            if (Fuel_Script.totalFuel > 0.1f) {
                jerryRb.MovePosition(transform.position + movementVec);
                movementVec = new Vector3(horizontalMovement, thrust);
            }
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
