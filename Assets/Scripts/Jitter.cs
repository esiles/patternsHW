using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Jitter : Movement {
	public float maximum = 2.0f;
	public float minimum = -2.0f;
	public float t = 0.0f;

	/*// Use this for initialization
	void Start () {
	
	}*/
	
//	Update is called once per frame
	void Update ()
	{
		
	}
	public override void move(Transform t)
	{
		t.position = t.position + t.forward * 0.5f;


		Vector3 v = t.rotation.eulerAngles;
		v.y = UnityEngine.Random.Range (-.5f, .5f);
		v.x = UnityEngine.Random.Range (-.5f, .5f);
		v.z = UnityEngine.Random.Range (-.5f, .5f);

		t.position+= v;



	}
}
