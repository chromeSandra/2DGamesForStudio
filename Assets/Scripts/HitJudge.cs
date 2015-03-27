using UnityEngine;
using System.Collections;

public class HitJudge : MonoBehaviour {
	public int score;
	public int health;
	private float startPauseTime;
	private float startFasterTime;
	public float pausePeriod;
	public float fastenPeriod;
	private float fastenTime;
	private float pauseTime;
	private bool pause = false;
	private bool faster = false;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Head") {
						score += 1;
			            startFasterTime = Time.time;
			fastenTime = 0;
						Debug.Log ("Hit the Head");
				}
		if (coll.gameObject.name == "Tail") {
			health -= 1;
			pause = true;
			startPauseTime = Time.time;
			pauseTime = 0;
			Debug.Log("Hit the tail, start pause on " + startPauseTime);
		}
	}
	// Update is called once per frame
	void Update () {
		if (pause && pauseTime <= pausePeriod * 0.0001) {
						pauseTime = Time.time - startPauseTime;
						Time.timeScale = 0.0001f;
						Debug.Log (pauseTime);
				} else if (faster && fastenTime <= fastenPeriod) {
			fastenTime = Time.time - startFasterTime;
			Time.timeScale = 2f;
			Debug.Log (fastenTime);
		}
			else {
				pause = false; 
			faster = false;
				Time.timeScale = 1;
			}   
  	    }
  }

