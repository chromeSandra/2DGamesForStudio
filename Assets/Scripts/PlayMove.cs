using UnityEngine;
using System.Collections;

public class PlayMove : MonoBehaviour {
	public bool enabled = true;
	public float speed = 3.0f;
	public bool isWalk = false;
	//private Animator animator;
//	private Rigidbody2D rigidbody;
//	private Animation ani;

	void Start () {
	//	animator = gameObject.GetComponent<Animator>();
		//rigidbody = gameObject.GetComponent<Rigidbody2D> ();
	//	ani = gameObject.GetComponent<Animation> ();
	}
	void FixedUpdate(){
				//Movement ();
				//	animator.SetBool ("Walk", isWalk);
				if (enabled) {
						if (Input.GetKey (KeyCode.A)) {
								//movex = -1;
								transform.Translate (Vector2.right * -speed * Time.deltaTime);
								isWalk = true;
								//	gameObject.animation.Play("Walk");
								//		Debug.Log ("Left");
						} else if (Input.GetKey (KeyCode.D)) {
								//movex = -1;
								transform.Translate (Vector2.right * speed * Time.deltaTime);
								isWalk = true;
								//		Debug.Log ("Right");
						} else if (Input.GetKey (KeyCode.W)) {
								//movex = -1;
								transform.Translate (Vector2.up * speed * Time.deltaTime);
								isWalk = true;
								//		Debug.Log ("Up");
						} else if (Input.GetKey (KeyCode.S)) {
								//movex = -1;
								transform.Translate (Vector2.up * -speed * Time.deltaTime);
								isWalk = true;
								//		Debug.Log ("Down");
						} else
								isWalk = false;
				}
		}


}
