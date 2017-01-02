using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedNotSeen : MonoBehaviour {
	public float yPos;
	public bool islookingatX;

	// Use this for initialization
	void Start () {
		yPos = transform.position.y;
		islookingatX = ((transform.eulerAngles.y % 180) == 0);
	}
	public bool lookedAway = true;
	public bool islooking = true;
	// Update is called once per frame
	void OnBecameInvisible() {
		islooking = false;    //This method to see if the cam is looking at the wall doesn't work
	}                         //It probably has something to do with the wall moving up
	void OnBecameVisible() {  //I could probably fix it but I don't care for not
		islooking = true;     //REMINDER: FIX THIS BUG
	}

	void Update () {
		//var camRot = Camera.main.transform.eulerAngles.y;                        //I should have done this a while ago
		var open = new Vector3 (transform.position.x, yPos+10, transform.position.z);	
		var closed = new Vector3 (transform.position.x, yPos, transform.position.z);
		var camPos = Camera.main.transform.position.x;
		var wallPos = transform.position.x;

		//bool islooking = GeometryUtility.CalculateFrustumPlanes; //Not an actual solution, change later
		//possibally (camRot >= 180 && camPos > wallPos) || (camRot < 180 && camPos < wallPos);
		//camRot < 180   Toward END
		//camRot >= 180    Away END
		//camPos > wallPos In room
		//camPos < wallPos Out room
		//transform.position is what you need to use for if wall open or not

		//So this is when the wall is definitely OPEN!
		if (islooking == false) {
			transform.position = open;
			lookedAway = true;
		} 
		if (Input.GetKey ("s") && lookedAway == true && (islooking == true)) {
			lookedAway = false;
		}
		if ((lookedAway == true) && (islooking == true) && !Input.GetKey ("s")) {
			transform.position = closed;
			lookedAway = false;
		}
		//Ok, so I know if you are facing away from the wall, you have looked away, but this should happen once
		/*
		if ((transform.position.x == 15) && ((camRot >= 180 && camPos < wallPos) || (camRot < 180 && camPos > wallPos))){
			lookedAway = true;
		}
		*/
		//Ok, so I need the wall to be visible when needed, so I kind of need the wall to always face the player
		if (camPos < wallPos) {
			//transform.rotation = Quaternion.Euler (transform.eulerAngles.x, 0, transform.eulerAngles.z);
			transform.rotation = Quaternion.Euler (90, 0, 90);   //Dude, I have no idea why these are different
		}
		if (camPos > wallPos) {
			//transform.rotation = Quaternion.Euler (transform.eulerAngles.x, 180, transform.eulerAngles.z);
			transform.rotation = Quaternion.Euler (90, 180, 90);
		}
		/*
		if (islookingatX == true) {

		} else {
			if (Camera.main.transform.position.y < transform.position.y) {
				transform.rotation = Quaternion.Euler (transform.eulerAngles.x, 90, transform.eulerAngles.z);
			}
			if (Camera.main.transform.position.y > transform.position.y) {
				transform.rotation = Quaternion.Euler (transform.eulerAngles.x, 270, transform.eulerAngles.z);
			}
		}
		*/

	}
}
/*
 * Ok, so here's the plan of what's supposed to happen:
 * |   |          |     is the room
 * 
 *     |
 * |              |     is the door open
 * 
 *    o> is the player, arrow pointing to camera
 * 
 *  
 */