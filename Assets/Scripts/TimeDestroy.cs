using UnityEngine;
using System.Collections;

public class TimeDestroy : MonoBehaviour {

	private float t = 10.0f;
	// Use this for initialization
	void Start () {

		Destroy (gameObject, t);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
