using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player")
		{
			other.gameObject.SetActive(false);
			gameObject.SetActive(false);
		}
		else if (other.tag == "Gate")
		{
			Destroy(gameObject);
		}
	}
}
