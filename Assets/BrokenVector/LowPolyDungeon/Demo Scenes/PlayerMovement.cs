using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float baseSpeed = 12f;
	public float gravity = -9.8f;
	public float jumpHeight = 3f;

	public bool isGrounded;

	Vector3 velocity;

	void Start()
	{
		// Makes player movement smoother
		controller = GetComponent<CharacterController>();
	}
	void Update()
	{

		// JUMP FEATURES
		if (Input.GetButtonDown("Jump"))
		{
			velocity.y = -2f;
			isGrounded = false;
		}

		if (controller.isGrounded)
		{
			velocity.y = -2f;
			isGrounded = true;
			if (Input.GetButtonDown("Jump"))
			{
				velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
			}
		}

		velocity.y += gravity * Time.deltaTime;

		// GENERAL MOVEMENT FEATURES
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;

		controller.Move(move * baseSpeed * Time.deltaTime);

		controller.Move(velocity * Time.deltaTime);

	}
}