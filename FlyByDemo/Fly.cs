using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(gameObject.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3(0,0,50)*Time.deltaTime;
		//gameObject.transform.position *= Time.deltaTime;
	}
}
