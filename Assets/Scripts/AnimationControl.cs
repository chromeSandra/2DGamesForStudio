using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour {
	private Animator animator;
	PlayMove moveScript;
	private bool walk;
	// Use this for initialization
	void Start () {
		moveScript = GameObject.Find ("Faces").GetComponent<PlayMove> ();
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		walk = moveScript.isWalk;
		animator.SetBool ("Walk", walk);
	}

}
