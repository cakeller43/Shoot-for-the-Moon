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
	public bool restart = false;
	public GUIText scoreText;
	private GUIText titleText;
	private GUIText subText;
	public GameObject gate;
	public GameObject asteroid;
	public GameObject moon;
	public int level;

	private float score = 0;
	private Movement movement;
	private PlayerController playerController;


		void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
		playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
		titleText = GameObject.FindWithTag ("Title Text").guiText;		
		subText = GameObject.FindWithTag ("Sub Text").guiText;

		StartCoroutine(SpawnAsteroids());
		StartCoroutine(SpawnGates());
		
		titleText.text = "";
		subText.text = "";
	}
	
	void Update()
	{
		// Score display
		score += movement.move.z * Time.deltaTime * 100;
		string scoreString = string.Format("{0:0.##}", score);
		scoreText.text = "Score: " + scoreString;
		
		// Restart
		if (restart && Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel(Application.loadedLevel);
		
		// Next level
		if (win && Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel(level + 1);
//			Application.LoadLevel(Application.loadedLevel);
//			scoreGoal *= 50.0f;
//			asteroidWait -= 0.05f;
			win = false;
		}
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
			moon.SetActive(true);
		
		// Game Over
		if ((movement.move == Vector3.zero && !win) || playerController.health <= 0)
		{
			titleText.text = "GAME OVER";
			subText.text = "Press \"R\" to restart";
			
			restart = true;
		}
	}
}
