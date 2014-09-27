using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour
{
	private Movement movement;
	
	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
			movement.move = Vector3.zero;
	}
}
