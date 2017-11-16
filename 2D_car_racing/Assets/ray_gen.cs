using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray_gen : MonoBehaviour {

	public float[] ray_angles = {-60, -30, 0, 30, 60};
	public float[] ray_dist = new float[5];
	public RaycastHit2D hit;
	public bool spotted;
	public Transform sightStart, sightEnd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < 5; ++i) {

			var newVector = Quaternion.Euler (0, 0, ray_angles[i]) * transform.up;

			hit = Physics2D.Raycast (sightStart.position, newVector, 1 << LayerMask.NameToLayer ("Wall"));

			ray_dist [i] = hit.distance;
			Debug.DrawLine (sightStart.position, hit.point, Color.green);

		}
		Debug.Log (ray_dist[0]);
		Debug.Log (ray_dist[1]);
		Debug.Log (ray_dist[2]);
		Debug.Log (ray_dist[3]);
		Debug.Log (ray_dist[4]);

	}
}
