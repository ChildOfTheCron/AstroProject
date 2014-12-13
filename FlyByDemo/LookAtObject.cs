using UnityEngine;
using System.Collections;

/*This script will return output based on the angle an object is being viewed at from a different object (in this case the camera)
It does this by using the dot product to multiply the two Vector3's of the two game objects.
Taken from the API reference, the dot product is a float value (a scalar value) equal to the magnitudes of the two vectors multiplied together
and then multiplied by the cosine of the angle between them. (The cos would be the angle between the two Vectors) */
public class LookAtObject : MonoBehaviour {

	//Initialising some vars to store coordinates of the objects vectors
	Vector3 myCurrentFront;
	Vector3 planet1Pos;
	Vector3 currentPos;
	Vector3 dirMeToObj;
	Transform tmpStore;
	Transform tmpMyVec;

	float tmpStoreX;
	float tmpStoreY;
	float tmpStoreZ;

	float tmpMyVecX;
	float tmpMyVecY;
	float tmpMyVecZ;

	//If we are viewing the secondary object from x angle this is toggled and we have output
	public bool IsActive;

	// Use this for initialization
	void Start () {
		IsActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		calcLookAt();
	}

	void calcLookAt(){
		//We get the current facing of the primary game object
		//We use this to ensure the other game object is infront of us
		myCurrentFront = gameObject.transform.forward;
		
		//Temp store for the other objects transform (Planet1)
		tmpStore = GameObject.Find("Planet1").gameObject.transform;
		//Primary game object's (camera) transform is stored in here
		tmpMyVec = gameObject.transform;

		//Storing each separate coordinate for a vector, from both primary and secondary game objects
		//This is to build two Vector3's to be used in the Dot Product calculation
		tmpMyVecX = tmpMyVec.position.x;
		tmpMyVecY = tmpMyVec.position.y;
		tmpMyVecZ = tmpMyVec.position.z;
		
		tmpStoreX = tmpStore.position.x;
		tmpStoreY = tmpStore.position.y;
		tmpStoreZ = tmpStore.position.z;

		//Building the new Vectors to be used in the comparison calculation
		planet1Pos = new Vector3(tmpStoreX, tmpStoreY, tmpStoreZ);
		currentPos = new Vector3(tmpMyVecX, tmpMyVecY, tmpMyVecZ);

		//Gets the magnitude of the primary object to the secondary one and then normalizes it
		dirMeToObj = (planet1Pos - currentPos).normalized;

		//180 degrees infront of us - performs the .Dot product calculation between the direction value and the front facing part of the primary objects transform
		if(Vector3.Dot (dirMeToObj, myCurrentFront) > 0){
			//Debug.Log ("Looking at Planet Area at 180 degrees");
		}

		//90 degrees infront of us
		if(Vector3.Dot (dirMeToObj, myCurrentFront) > 0.5){
			//Debug.Log ("Looking at Planet Area at 90 degrees");
		}

		//45 degrees infront of us
		if(Vector3.Dot (dirMeToObj, myCurrentFront) > 0.75){
			Debug.Log ("Looking at Planet Area at 45 degrees");
			Debug.Log (Vector3.Dot (dirMeToObj, myCurrentFront)); //used for debugging
			IsActive = true;
		}else{
			IsActive = false;
		}
	}

	public bool getIsActive(){
		return IsActive;
	}

}
