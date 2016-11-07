using UnityEngine;
using System.Collections;

public class RightHandBallFire : MonoBehaviour {

	public GameObject bullet_red;
	public GameObject spawnRed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire2")) {
			Instantiate (bullet_red, spawnRed.transform.position, spawnRed.transform.rotation);

		}
	}


}