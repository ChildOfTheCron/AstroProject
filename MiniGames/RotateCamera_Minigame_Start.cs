using UnityEngine;
using System.Collections;

public class RotateCamera_Minigame_Start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0F;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey){
			Time.timeScale = 1F;
			Destroy(GameObject.Find("RawImage"));
			Destroy(GameObject.Find("Text"));
		}
	}
}
