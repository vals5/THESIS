using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Fox controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	public Animator animator;
	
	void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("isJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
		if (!Fox.isGameStarted)
			return;
	}
	void FixedUpdate()
	{		
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;

		if (!Fox.isGameStarted)
			return;
	}
	public void OnLanding()
    {
		animator.SetBool("isJumping", false);
    }
	public void OnCrouching(bool isCrouching)
    {
		animator.SetBool("isCrouching", false);
    }
}