using UnityEngine;
using System.Collections;

public class LoadRotateDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "Main Camera"){
			//Destroy(gameObject);
			Application.LoadLevel("RotateDemo");
		}
	}
}
