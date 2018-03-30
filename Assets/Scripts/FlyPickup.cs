using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour {

	[SerializeField]
	private GameObject prefabPickup;

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			Instantiate (prefabPickup, transform.position, Quaternion.identity);
			FlySpawner.totalFlies--;
			ScoreCounter.score++;
			Destroy (gameObject);
		}
	}
}
