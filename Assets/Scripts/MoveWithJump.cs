using UnityEngine;
using System.Collections;

public class MoveWithJump : MonoBehaviour {
	public bool enabled = true;
	public float speed = 3.0f;
	public float jumpSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
				if (enabled) {
			if(Input.GetKeyDown(KeyCode.Space)){
				rigidbody2D.AddForce(Vector2.up * jumpSpeed);
			}
						if (Input.GetKey (KeyCode.A)) {
								transform.Translate (Vector2.right * -speed * Time.deltaTime);
								//		Debug.Log ("Left");
						} else if (Input.GetKey (KeyCode.D)) {
								transform.Translate (Vector2.right * speed * Time.deltaTime);
								//		Debug.Log ("Right");
						}
				}
		}
}
