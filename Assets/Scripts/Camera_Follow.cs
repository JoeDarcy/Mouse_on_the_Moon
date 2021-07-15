using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    [SerializeField] private Transform jerryTransform = null;
	[SerializeField] private float smoothing = 10.0f;
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 0, 0);

	private float xPos = 0.0f;
	private float zPos = -10.0f;

	private void FixedUpdate() {
		Vector3 correctedPos = new Vector3(xPos, jerryTransform.position.y, zPos);
		Vector3 finalPosition = correctedPos + cameraOffset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, finalPosition, smoothing * Time.deltaTime);
		transform.position = smoothedPosition;
		
	}
}
