using UnityEngine;
using System.Collections;

public class UpdateManager : MonoBehaviour {

	RayCast raycast;
	GameObject panelobj;

	// Use this for initialization
	void Start () {
		raycast = GameObject.Find("Main Camera").gameObject.GetComponent<RayCast>();
		panelobj = GameObject.Find("Panel");
		panelobj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(raycast.getIsActive()){
			Debug.Log("Yay isActive can be seen");
			panelobj.SetActive(true);
		}else{
			panelobj.SetActive(false);
		}
	}
}
