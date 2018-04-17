using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField]
	private GameObject[] Apple; //The array of apples
	private BoxCollider2D coll; //The collider for the apples
	float lim1, lim2; //The limits within which apples can spawn

	void Awake () {
		coll = GetComponent<BoxCollider2D> ();
		lim1 = transform.position.x - coll.bounds.size.x / 2f; //What the limits are;
		lim2 = transform.position.x + coll.bounds.size.x / 2f;
	}

	void Start () {
		StartCoroutine (SpawnApple (1f));
	}
	
	// Update is called once per frame
	void Update () {
	}

	//Make the apple
	IEnumerator SpawnApple (float time) {
		yield return new WaitForSeconds (time);
		Vector3 pos = transform.position; //Determine the position of each apple
		pos.x = Random.Range (lim1, lim2); //Randomly spawn in apples within this range on x
		Instantiate(Apple[Random.Range(0,Apple.Length)], pos,Quaternion.identity);
		StartCoroutine (SpawnApple (Random.Range (1f, 2f))); //Continually spawn apples in the range of the spawner, ends when game is lost/won
	}
}