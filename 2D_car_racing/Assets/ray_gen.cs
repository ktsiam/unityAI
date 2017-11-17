using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray_gen : MonoBehaviour {

	public float[] ray_angles = {-80, -30, 0, 30, 80};
	public float[] ray_dist = new float[5];
	public RaycastHit2D hit;
	public bool spotted;
	public Transform sightStart, sightEnd;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnGUI() {
		string text = "";

		for (int i = 0; i < 5; ++i) {
			text += "dist: " + ray_dist [i].ToString("F2") + "\n";
		}

//		string text = ray_dist [0].ToString ();
		GUI.Label(new Rect(100, 100, 100, 200), text);
	}
	void Update () {

		for (int i = 0; i < 5; ++i) {

			var newVector = Quaternion.Euler (0, 0, ray_angles[i]) * transform.up;

			hit = Physics2D.Raycast (sightStart.position, newVector, 1 << LayerMask.NameToLayer ("Wall"));

			ray_dist [i] = hit.distance;
			Debug.DrawLine (sightStart.position, hit.point, Color.green);

		}
//		Debug.Log (ray_dist[0]);
//		Debug.Log (ray_dist[1]);
//		Debug.Log (ray_dist[2]);
//		Debug.Log (ray_dist[3]);
//		Debug.Log (ray_dist[4]);

	}
}
