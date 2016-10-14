using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Straight : Movement {

	// Use this for initialization
	/*void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	public override void move(Transform t)
	{
		t.position = t.position + t.forward * 0.5f;
	}
}
