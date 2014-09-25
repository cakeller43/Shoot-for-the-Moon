using UnityEngine;
using System.Collections;

public class Accelerator : MonoBehaviour
{
	private Movement movement;
	
	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			movement.gate = true;
			Debug.Log("COLLIDE");
		}
	}
}
