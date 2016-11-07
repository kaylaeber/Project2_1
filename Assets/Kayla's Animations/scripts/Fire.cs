using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public float speed = 2f;
	float timer = 0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		MoveFire ();
	}

	void MoveFire() {
		timer += Time.deltaTime;
		if (timer < 6f) {
			transform.Translate (0, speed * Time.deltaTime, 0);
			this.GetComponent<SpriteRenderer>().enabled = true;
		} else if (timer >= 6f && timer < 8f) {
			
		} else if (timer >= 6f && timer < 8f) {
			transform.Translate (0, -speed * Time.deltaTime, 0);
		} else if (timer >= 6f)
			this.GetComponent<SpriteRenderer>().enabled = false;
	}

}
