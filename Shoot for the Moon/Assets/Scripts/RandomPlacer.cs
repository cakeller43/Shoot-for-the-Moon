using UnityEngine;
using System.Collections;

public class RandomPlacer : MonoBehaviour
{
	public float range;
	
	void Start()
	{
		Vector3 position = new Vector3(Random.Range(-range, range),
		                               transform.position.y,
		                               transform.position.z);
		transform.position = position;
	}
}
