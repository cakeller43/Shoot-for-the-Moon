using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float smooth;
	public GameObject center;
	public int health;

	private bool win = false;
	
	void FixedUpdate()
	{
		if (!win)
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
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Moon")
		{
			rigidbody.velocity = Vector3.zero;
			win = true;
		}
	}

	public void decrementHealth()
	{
		health = health - 1;
	}

	public int getHealth()
	{
		return health;
	}
}
