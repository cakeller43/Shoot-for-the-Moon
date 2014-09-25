using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GUIText scoreText;
	
	private Movement movement;
	private float score = 0;
	
	void Start()
	{
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
	}
	
	void Update()
	{
		// Score display
		score += movement.move.z * Time.deltaTime * 100;
		string scoreString = string.Format("{0:0.##}", score);
		scoreText.text = "Score: " + scoreString;
	}
}
