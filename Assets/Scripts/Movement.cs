using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public bool enabled = true;
	public float speed = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enabled) {
			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (Vector2.right * -speed * Time.deltaTime);
				//		Debug.Log ("Left");
			} else if (Input.GetKey (KeyCode.D)) {
				transform.Translate (Vector2.right * speed * Time.deltaTime);
				//		Debug.Log ("Right");
			} else if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector2.up * speed * Time.deltaTime);
				//		Debug.Log ("Up");
			} else if (Input.GetKey (KeyCode.S)) {			
				transform.Translate (Vector2.up * -speed * Time.deltaTime);
				//		Debug.Log ("Down");
			}
	
	    }
    }
}