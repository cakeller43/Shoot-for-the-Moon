using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public Movement movement;
	
	void FixedUpdate()
	{
		Vector3 move = movement.move;
		move = move * Time.deltaTime;
		
		transform.position = transform.position - move;
	}
}
