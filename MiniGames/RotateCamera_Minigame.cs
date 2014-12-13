using UnityEngine;
using System.Collections;

public class RotateCamera_Minigame : MonoBehaviour {

	/* Version 0.1 - When attached to the Camera in a scene, will rotate the camera based on a different rotation
	*This different rotation is gathered by taking it from a different game object that I set up in the scene.
	*This allows me to change the target rotation easily and visually */

	/* Version 0.2 - The rotation will now occur on start up but if the left trigger on a pad is selected
	 * the camera will start to pan towards its original rotation */

	/* Version 0.3 - The camera will now spin towards a different objects rotation along two different axis
	 * well the same axis just around different rotations (-step and +step).
	 * In both cases the user can use Left Trigger on the pad to slowly balance to camera back to the center.
	 * Direction will be one direction in one moment and then another after 5 seconds */

	/* Version 0.4 - Replaced IEnumerator timeToTurn() and StartCoroutine(timeToTurn()); and yield waitForSeconds with InvokeRepeating
	 * This is a better solution and is easier to manipulate
	 * Added a boolean toggle to timeToTurn to switch between the two rotations (-Step and +Step) */

	/* Version 0.5 - Added a Jump mechanic. Every 2 seconds the camera will "Jump" in a direction (-Step / +Step)
	 * This will happen regardless of user input.
	 * This is a basic version and the plan is to have the user adjust their input based on the jump boolean.
	 * For now this just takes control away from the player and make the "Out of Control" spin, feel more out of control. */

	/* Version 0.6 - Added a thrust mechanic. This mechanic allows the player to regain control after the Jump mechanic takes place
	 * If the camera "Jump" out of control the player can press A for thrust to regain control and continue rebalancing
	 * Added a secondary trigger (right trigger) to rebalance the camera to the center when rotating to the right.
	 * Now Left Trigger centers from Left rotation and Right Trigger centers from Right Rotation
	 * Refactored code that deals with camera rotation to make better use of the second trigger */

	/* Version 0.7 - Added pause state and basic controls UI. 
	 * On any key game starts, UI gets destroyed
	 * Added Escape functionality. Start button on pads - Escape on keyboard */

	float speed; //Speed of the rotation
	Transform target; //Target rotation (transform really)
	Transform storeOrig;//Used to store camera's original rotation (transform really)

	//Direction toggle (To switch between left and right on axis)
	//Control Jump to "Jump" the camera in a direction determinted by directionRot ever x seconds. User input is ignored after a jump
	bool directionRot;
	bool controlJump;

	// Use this for initialization
	void Start () {
		//Initialization of game objects here, to use their rotations in Update
		//Assigning the speed as well
		speed = -60F;
		target = GameObject.Find("Rot1").gameObject.transform; //Placeholder object, could be anything really
		//Can't do "storeOrig = gameObject.transform;" because the rotations won't be correct
		//And trying gameObject.transform.rotation causes issues with the RotateTowards function
		storeOrig = GameObject.Find("ResetRot").gameObject.transform;

		//Initialization of the coroutine and all its required variables
		//Giving the direction a default via directionRot
		directionRot = true;
		controlJump = true;
		//Start up the Repeats!
		InvokeRepeating("timeToTurn", 5, 5F);
		InvokeRepeating("controlJumper", 2, 2F);
	}

	void drawIntro(){

	}

	void controlJumper(){
		//Adding a boolean toggle
		if(controlJump == true){
			controlJump = false;
		}else{
			controlJump = true;
		}
	}

	void timeToTurn(){
		//Adding a boolean toggle
		if(directionRot == true){
			directionRot = false;
		}else{
			directionRot = true;
		}
	}

	public void quit(){
		Application.LoadLevel(0);
	}

	// Update is called once per frame
	void Update () {
		//Frame independant over time - rotates towards target rotation
		float step = speed * Time.deltaTime;

		/*For some reason it really matters which way around I increment or decrement the step.
		*I have no idea why but this way will make it work. I'm going to have to read into Quaternion components when I get time
		*So that I can fine tune things like this.
		*The API refrence says "Don't modify this directly unless you know quaternions inside out" for the components
		*So I'll have to leave this for now. Mechanic works though! */
		if((Input.GetAxis("Infra") < 0.5F || Input.GetKey(KeyCode.D)) && controlJump == true && directionRot == true){
			transform.rotation = Quaternion.RotateTowards(transform.rotation, storeOrig.rotation, -step);
		}else{
			if(directionRot == true){
				transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
				Debug.Log("directionRot == true " + directionRot);
			}
		}

		if((Input.GetAxis("Infra") > 0.5F || Input.GetKey(KeyCode.A)) && controlJump == true && directionRot == false){
			transform.rotation = Quaternion.RotateTowards(transform.rotation, storeOrig.rotation, -step);
		}else{
			if(directionRot == false){
				transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, -step);
				Debug.Log("directionRot == false " + directionRot);
			}
		}

		if(Input.GetButtonUp("Thrust") || Input.GetKey(KeyCode.S)){
			controlJump = true;
			Debug.Log("A BUTTON PRESSED");
		}

		if(Input.GetButtonUp("Start") || Input.GetKey(KeyCode.Escape)){
			quit();
		}
	}
}
