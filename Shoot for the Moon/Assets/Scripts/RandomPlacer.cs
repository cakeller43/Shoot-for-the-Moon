using UnityEngine;
using System.Collections;

public class RandomPlacer : MonoBehaviour
{
	public float range;
	
	void Start()
	{
		float random = Random.Range(-range, range);
		Vector3 position = new Vector3(random,
		                               transform.position.y,
		                               transform.position.z);
		transform.position = position;
	}
}
