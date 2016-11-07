using UnityEngine;
using System.Collections;

public class InteractionCollider : MonoBehaviour {

	public GameObject bubblePrefab;
	public Vector3 startPos;
	public bool first = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (!first) {
			Instantiate(bubblePrefab, startPos + transform.position, Quaternion.identity);
			first = true;

		}



}
}


	
