using UnityEngine;
using System.Collections;

public class ContactDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}
