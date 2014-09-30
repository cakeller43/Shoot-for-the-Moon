using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	private Movement movement;

	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player")
		{
			gameObject.SetActive(false);
			other.gameObject.GetComponent<PlayerController>().decrementHealth();
			movement.slowSpeed();
			if(other.gameObject.GetComponent<PlayerController>().getHealth() <= 0)
				other.gameObject.SetActive(false);
				
		}
		else if (other.tag == "Gate")
		{
			Destroy(gameObject);
		}
	}
}
