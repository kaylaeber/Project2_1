using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShotCounter : MonoBehaviour {

	public bool first = false;

	public int heavenscore;
	public Text heavenScoreText;

	// Use this for initialization
	void Start () {

		heavenscore = 0;
		if(heavenScoreText != null){

			heavenScoreText.text = heavenscore.ToString();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		AddToPlayerScore (1);
	
	}

	public void AddToPlayerScore (int addScore)
	{
		heavenscore = heavenscore + addScore;
		Debug.Log ("Score is: " + heavenscore);
		heavenScoreText.text = heavenscore.ToString ();
	}
}