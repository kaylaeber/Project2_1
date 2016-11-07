using UnityEngine;
using System.Collections;

public class RightHandShoot: MonoBehaviour {

	public Sprite RightHandIdle;
	public Sprite RightHandShooting;
	private SpriteRenderer spriteRenderer;

	private bool isShooting;
	private float shootTimer;            

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update () {

		// set attack sprite and flag the frame that a key is down.
		if (Input.GetButtonDown("Fire2")) 
		{
			this.isShooting = true;
			this.spriteRenderer.sprite = RightHandShooting;
			this.shootTimer = 0f;

		}

		// while attacking, count up the timer.
		if (this.isShooting)
		{
			this.shootTimer += Time.deltaTime;

			// once the timer is 2 seconds, stop attacking and reset the sprite.
			if (this.shootTimer >= 1f)
			{
				this.isShooting = false;
				this.shootTimer = 0f;
				spriteRenderer.sprite = RightHandIdle; 
			}
		}
	}
}