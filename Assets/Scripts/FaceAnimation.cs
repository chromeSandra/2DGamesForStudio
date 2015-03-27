using UnityEngine;
using System.Collections;

public class FaceAnimation : MonoBehaviour {

	private Animator ani;
	PlayMove animation;
	// Use this for initialization
	void Start () {
		animation = GameObject.Find("Faces").GetComponent<PlayMove>();
		ani = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
			ani.SetBool ("Walk", animation.isWalk);
	}
}
