using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
	public bool enabled = true;
	public float speed = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (enabled) {
				if (Input.GetKey (KeyCode.LeftArrow)) {
					transform.Translate (Vector2.right * -speed * Time.deltaTime);
					//		Debug.Log ("Left");
				} else if (Input.GetKey (KeyCode.RightArrow)) {
					transform.Translate (Vector2.right * speed * Time.deltaTime);
					//		Debug.Log ("Right");
				} else if (Input.GetKey (KeyCode.UpArrow)) {
					transform.Translate (Vector2.up * speed * Time.deltaTime);
					//		Debug.Log ("Up");
				} else if (Input.GetKey (KeyCode.DownArrow)) {			
					transform.Translate (Vector2.up * -speed * Time.deltaTime);
					//		Debug.Log ("Down");
			}
	    }
   }
}
