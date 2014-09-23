using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float smooth;
	
	public GameObject center;
	
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		
		// Snap back to center
		transform.position = Vector3.Lerp(transform.position,
		                                  center.transform.position,
		                                  smooth * Time.deltaTime);
		
		// Horizontal movement
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
		rigidbody.velocity = movement * speed;
	}
}
