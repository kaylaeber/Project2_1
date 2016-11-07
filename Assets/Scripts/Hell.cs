using UnityEngine;
using System.Collections;

public class Hell : MonoBehaviour {

	public GameObject fire;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("hit with red");
		if (other.name == "bullet_red(Clone)") {
			Debug.Log ("hit with red");
			fire.GetComponent<Animation> ().Play ();

		}
	}

}


