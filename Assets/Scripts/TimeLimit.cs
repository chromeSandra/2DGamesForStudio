using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour {
	GameObject mybutton;
	GameObject text;
	GameTime time;
	PlayMove canmove;
	// Use this for initialization
	void Start () {
		mybutton = GameObject.Find ("RestartButton");
		text = GameObject.Find ("Over");
		canmove = GameObject.FindWithTag ("Player").GetComponent<PlayMove>();
		time = GameObject.Find ("Timer").GetComponent<GameTime> ();
	}

	// Update is called once per frame
	void Update () {
	     if (time.gamestop) {
						canmove.enabled = false;
			mybutton.GetComponent<Button>().interactable = true;
			text.GetComponent<Text>().enabled = true;
				}
	}

	public void Restart(){
		Application.LoadLevel (0);
		Debug.Log ("Restart");
	}
}
