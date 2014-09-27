using UnityEngine;
using System.Collections;

public class RandomSizer : MonoBehaviour
{
	public float range;
	
	void Start()
	{
		float random = Random.Range(-range, range);
		Vector3 scale = new Vector3(random, random, random);
		transform.localScale = transform.localScale + scale;
	}
}
