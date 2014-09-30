using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour 
{
	public bool isQuit;

	void Update()
	{
		if (Input.GetKey (KeyCode.Escape)) 
		{
						Application.Quit ();
		}
	}

	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
	}

	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}

	void OnMouseUp()
	{
		if (isQuit)
						Application.Quit ();
				else
						Application.LoadLevel (1);
	}
}
