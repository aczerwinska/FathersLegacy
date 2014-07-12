using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	
	public float speed;
	public float turnSmoothing = 15f;

	void FixedUpdate()
	{
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


		MovementManagement(moveHorizontal, moveVertical);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void Rotating(float horizontal, float vertical)
	{
	
		Vector3 targetDirection = new Vector3 (horizontal, 0f, vertical);
	
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);

		Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);

		rigidbody.MoveRotation(newRotation);

	}

	void MovementManagement (float horizontal, float vertical)
	{		
				// If there is some axis input...
				if (horizontal != 0f || vertical != 0f) {
						// ... set the players rotation 
						Rotating (horizontal, vertical);
				} 
				else 
				{	
					rigidbody.velocity = Vector3.zero;
					rigidbody.angularVelocity = Vector3.zero;		
				}
						
	}

}
