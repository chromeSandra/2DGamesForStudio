using UnityEngine;
using System.Collections;

public class PlayAnimations : MonoBehaviour {
	private Animator animator;
	private bool isWalk;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();

		isWalk = false;
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetBool ("Walk", isWalk);
		if (Input.GetKeyDown(KeyCode.A)){
			isWalk = true;
			Debug.Log(isWalk);
		}
		if (Input.GetKeyDown(KeyCode.B)){
			isWalk = false;
			Debug.Log(isWalk);
		}
	}
}
