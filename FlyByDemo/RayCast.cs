using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	//RaycastHit hit;
	public bool IsActive;
	// Use this for initialization
	void Start () {
		IsActive = false;
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		Ray ray = new Ray(gameObject.transform.position*2, gameObject.transform.forward);

		Debug.DrawRay(transform.position, gameObject.transform.forward*500);

		if(Physics.Raycast(ray, out hit, 500, 9)) //Mathf.Infinity
		{
			Debug.Log(hit.collider.name);
			if(hit.collider.name == "Planet1")
			{
				Debug.Log("RaycastWorking");
				IsActive = true;
			}else{
				IsActive = false;
			}
		}
	}

	public bool getIsActive(){
		return IsActive;
	}
}
