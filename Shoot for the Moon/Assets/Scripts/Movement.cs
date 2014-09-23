using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public Vector3 move;
    
    private Vector3 initial;
	
    void Start()
    {
        initial = move;
    }
    
	void FixedUpdate()
	{
		move = initial * Time.deltaTime;
	}
}
