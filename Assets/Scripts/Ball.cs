using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public Movement trait = new Straight();

	void Start()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		trait.move(transform); 
	
	}
}
