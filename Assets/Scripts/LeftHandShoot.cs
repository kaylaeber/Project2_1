using UnityEngine;
using System.Collections;

public class LeftHandShoot: MonoBehaviour {

	public Sprite LeftHandIdle;
	public Sprite LeftHandShooting;
	private SpriteRenderer spriteRenderer;

	private bool isShooting;
	private float shootTimer;            

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update () {

		// set attack sprite and flag the frame that a key is down.
		if (Input.GetButtonDown("Fire1")) 
		{
			this.isShooting = true;
			this.spriteRenderer.sprite = LeftHandShooting;
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
				spriteRenderer.sprite = LeftHandIdle; 
			}
		}
	}
}