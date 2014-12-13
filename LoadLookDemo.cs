using UnityEngine;
using System.Collections;

public class LoadLookDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name == "Main Camera"){
			//Destroy(gameObject);
			Application.LoadLevel("FlyByDemo");
		}
	}

	//Quick and dirty way to get to the main menu area
	void exit(){
		if (Input.GetKey(KeyCode.Escape)){
			Application.LoadLevel("Main"); //Load back to main menu (scene)
		}
	}
}
