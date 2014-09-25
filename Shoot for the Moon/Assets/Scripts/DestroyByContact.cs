using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
			return;
		
		other.gameObject.active = false;
		gameObject.active = false;
	}
}
