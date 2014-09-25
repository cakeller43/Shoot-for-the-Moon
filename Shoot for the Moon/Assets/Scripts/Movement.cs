using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	// Vector controlling how fast the ship moves
	public Vector3 move;
	// How much the ship is slowed down over time
	public float gravity;
	// Gravity is multiplied by this factor every new level
	public float difficultyStep;
	// Whether the ship has just passed through a gate
	[System.NonSerialized]
	public bool gate = false;
	
	private Vector3 initial;
	
	void Start()
	{
		move = move * Time.fixedDeltaTime;
		initial = move;
	}
	
	void FixedUpdate()
	{
		if (gate)
		{
			move = initial;
			gate = false;
		}
		else
		{
			float smooth = (1 / (move.z * gravity)) * Time.deltaTime;
			move = Vector3.Slerp(move, Vector3.zero , smooth);
		}
	}
}
