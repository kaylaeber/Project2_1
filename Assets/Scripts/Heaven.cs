using UnityEngine;
using System.Collections;

public class Heaven : MonoBehaviour {

	public GameObject cloud;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("hit");
		if (other.name == "bullet_blue(Clone)") {
			Debug.Log ("hit with blue");
			cloud.GetComponent<Animation> ().Play ();

		}
	}

}


