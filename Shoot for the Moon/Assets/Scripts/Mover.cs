using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float multiplier = 1;
	
	private Movement movement;
	
	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
	}
	
	void FixedUpdate()
	{
		Vector3 move = movement.move;
		move = move * multiplier;
		
		transform.position -= move;
	}
}
