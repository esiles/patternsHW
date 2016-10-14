using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Angular : Movement {

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
	public override void move(Transform t)
	{
		bool check = true; 

			

		t.position = t.position + t.forward * 0.5f;
		while (check) {

			Vector3 v = t.rotation.eulerAngles;
			v.y = UnityEngine.Random.Range(-1f,1f);
			v.x = UnityEngine.Random.Range (-1f, 1f);
			v.z = UnityEngine.Random.Range (-1f, 1f);
			Vector3 angle = t.rotation.eulerAngles;
			t.rotation = Quaternion.Euler (angle.x + v.x, angle.y + v.y, angle.z + v.z);
			t.position = t.position + t.up;
			check = false;
		}
	}
}
