using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

	public Rigidbody2D rb;
	public int count = 1;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = (new Vector2 (0, 0));

	}

	void Update () {

		float rot = transform.localEulerAngles.z ;
		if (Input.GetKey ("a")) { 
			transform.localEulerAngles = new Vector3 (0.0f, 0.0f, rot + 4.0f);
		} else if (Input.GetKey ("d")) {
			
			transform.localEulerAngles = new Vector3 (0.0f, 0.0f, rot - 4.0f);
		} 
		rb.velocity = transform.up * 1;
	}
}

