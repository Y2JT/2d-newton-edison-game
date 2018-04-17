using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulbSpawn : MonoBehaviour {

	public Vector3[] positions;

	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range (0, positions.Length);
		transform.position = positions [randomNumber];
	}
}