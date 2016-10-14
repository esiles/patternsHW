using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {
	private ArrayList Balls = new ArrayList(); 
	GameObject o;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {

		o = other.gameObject;
		Balls.Add (o); 
	}

	void OnTriggerExit(Collider other)
	{
		Balls.Remove (o);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Iterating to update the objects in the gravity sphere
		for (int i = 0; i < Balls.Count; i++)
		{
			if(Balls[i].Equals(null))
			{
				Balls.Remove(Balls[i]);
				break;
			}

			o=(GameObject)Balls[i];
			Vector3 vec = o.transform.position - transform.position;
			vec.Normalize();
			o.transform.position -= vec * .02f;
		}
	
	}
}
