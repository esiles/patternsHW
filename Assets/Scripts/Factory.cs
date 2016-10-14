using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	private float spawnWait = 0.1f;
	public GameObject toMake;
	public Vector3 spawnValues;


	// Use this for initialization
	void Start () {
			
		StartCoroutine (Updater ());
	
	}
	
	// Update is called once per frame
	IEnumerator Updater () {
		yield return new WaitForSeconds (spawnWait);
		while (true) {
			
			spawnValues.y += UnityEngine.Random.Range (-20, 20);
			Object o = Instantiate (toMake, spawnValues, Quaternion.identity);
			GameObject go = (GameObject)o;
			Ball b = go.GetComponent<Ball> ();
			int pick = UnityEngine.Random.Range (0, 3);
			if (pick == 0) {
				b.trait = new Straight ();
			}
			
			if (pick == 1) {
				b.trait = new Jitter ();
			}

			if (pick == 2) {
				b.trait = new Angular ();
			}

			yield return new WaitForSeconds (spawnWait);
		}
	//	b.move = new Behaviour();
	
	}

	/*IEnumerator FactoryOn ()
	{
		yield return new WaitForSeconds (spawnWait);
		while (true) 
		{
			GameObject ball = Theball; 
			Vector3 spawnPosition = new Vector3(spawnValues.x,Random.Range(-spawnValues.y,spawnValues.y),spawnValues.z);//x=0,y=50,z=80
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (ball, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);

		}
	}*/
}
