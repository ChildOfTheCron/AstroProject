using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	Vector3 startSpawn = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("Testy test test");	
		this.gameObject.transform.position = startSpawn;
	}
}
