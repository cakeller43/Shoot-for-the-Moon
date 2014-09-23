using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
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
		move = move * multiplier * (1 / transform.localScale.y);
		float offset = renderer.material.mainTextureOffset.y;
		
		renderer.material.mainTextureOffset = new Vector2(0, offset + move.z);
	}
}
