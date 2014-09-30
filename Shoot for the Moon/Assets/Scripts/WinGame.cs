using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour
{
	private GUIText titleText;
	private GUIText subText;
	private Movement movement;
	private GameController gameController;
	
	void Start()
	{
		titleText = GameObject.FindWithTag ("Title Text").guiText;		
		subText = GameObject.FindWithTag ("Sub Text").guiText;
		movement = GameObject.FindWithTag("Movement").GetComponent<Movement>();
		gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			titleText.text = "THANK YOU NEIL!\nBUT OUR PRINCESS IS ON\nANOTHER MOON!";
			subText.text = "Press \"Space\" to go to the next level";
			gameController.win = true;
			movement.move = Vector3.zero;		

		}
	}
}
