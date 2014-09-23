using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{
	public Movement movement;
	
	void FixedUpdate()
	{
		Vector3 move = movement.move;
		move = Time.time * move * Time.deltaTime;
		
		renderer.material.mainTextureOffset = new Vector2(move.x, move.z);
	}
}
