using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	public float movementSpeed;
	public float mouseSensitivity;
	public float upDownRange;

	float verticalRotation = 0f;
	CharacterController cc;

	void Start () {
		cc = GetComponent<CharacterController>();

		// Prevent cursor from going out of the screen if game is windowed
		Screen.lockCursor = true;
	}

	void Update () {

		// Mouse controls

		// Rotate the character controller around the y-axis to turn from left to right
		float rotationLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate(0, rotationLeftRight, 0);

		// We don't want to rotate the character controller around the x-axis:
		// character controllers are always upright, and it would affect physics and collision
		// Instead, we change the pitch of the camera

		float rotationUpDown = -Input.GetAxis("Mouse Y") * mouseSensitivity;
		verticalRotation += rotationUpDown;
		verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

		// Keyboard controls

		float verticalSpeed = Input.GetAxis("Vertical") * movementSpeed;
		float horizontalSpeed = Input.GetAxis("Horizontal") * movementSpeed;
		// Axes: z = forward/backward, y = up/down, x = left/right
		Vector3 speed = transform.rotation * new Vector3(horizontalSpeed, 0, verticalSpeed);
		cc.SimpleMove(speed);
	}
}