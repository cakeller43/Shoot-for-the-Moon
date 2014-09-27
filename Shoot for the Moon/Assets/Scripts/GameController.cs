using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public float gateWait;
	public float asteroidWait;
	public float startWait;
	public float scoreGoal;
	public float asteroidVariation;
	public bool win = false;
	public GUIText scoreText;
	public GameObject gate;
	public GameObject asteroid;
	public GameObject moon;
	
	private float score = 0;
	private Movement movement;
	
	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
		
		StartCoroutine(SpawnAsteroids());
		StartCoroutine(SpawnGates());
	}
	
	void Update()
	{
		// Score display
		score += movement.move.z * Time.deltaTime * 100;
		string scoreString = string.Format("{0:0.##}", score);
		scoreText.text = "Score: " + scoreString;
	}
	
	IEnumerator SpawnGates()
	{
		yield return new WaitForSeconds(startWait);
		
		while (!win)
		{
			Instantiate(gate);
			
			yield return new WaitForSeconds(gateWait);
		}
	}
	
	IEnumerator SpawnAsteroids()
	{
		yield return new WaitForSeconds(startWait);
		
		while (!win)
		{
			Instantiate(asteroid);
			
			float randomWait = Random.Range(asteroidWait - asteroidVariation,
			                                asteroidWait + asteroidVariation);
			yield return new WaitForSeconds(randomWait);
		}
	}
	
	void FixedUpdate()
	{
		// Create moon
		if (score > scoreGoal && !win)
		{
			Instantiate(moon);
			win = true;
		}
	}
}
