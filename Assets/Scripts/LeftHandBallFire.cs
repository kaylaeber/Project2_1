using UnityEngine;
using System.Collections;

public class LeftHandBallFire : MonoBehaviour {

	public GameObject bullet_blue;
	public GameObject spawnBlue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (bullet_blue, spawnBlue.transform.position, spawnBlue.transform.rotation);
	
		}
	}

	

	

}