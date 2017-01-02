using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w")) {  //This has got to be the LEAST efficient way of writing a code for walking
			if (Camera.main.transform.eulerAngles.y > 45 && Camera.main.transform.eulerAngles.y < 135) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 315 || Camera.main.transform.eulerAngles.y < 45) { //I remember when I first did this, and I have it as && like everyone else, but I realized that you can't be both less than 45 and more than 315 (unless you are doing modular arythmatic, which is what rotation is, but it's not worth arguing)
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1);
			}
			if (Camera.main.transform.eulerAngles						.y > 225 && Camera.main.transform.eulerAngles.y < 315) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x - 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 135 && Camera.main.transform.eulerAngles.y < 225) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z - 1);
			}
			print (Camera.main.transform.eulerAngles.y);
		}
		if (Input.GetKey ("s")) {
			if (Camera.main.transform.eulerAngles.y > 45 && Camera.main.transform.eulerAngles.y < 135) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x - 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 315 || Camera.main.transform.eulerAngles.y < 45) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z - 1);
			}
			if (Camera.main.transform.eulerAngles.y > 225 && Camera.main.transform.eulerAngles.y < 315) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 135 && Camera.main.transform.eulerAngles.y < 225) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1);
			}
		}
		if (Input.GetKey ("a")) {
			if (Camera.main.transform.eulerAngles.y > 135 && Camera.main.transform.eulerAngles.y < 225) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 45 && Camera.main.transform.eulerAngles.y < 135) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1);
			}
			if (Camera.main.transform.eulerAngles.y > 315 || Camera.main.transform.eulerAngles.y < 45) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x - 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 225 && Camera.main.transform.eulerAngles.y < 315) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z - 1);
			}
		}
		if (Input.GetKey ("d")) {
			if (Camera.main.transform.eulerAngles.y > 135 && Camera.main.transform.eulerAngles.y < 225) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x - 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 45 && Camera.main.transform.eulerAngles.y < 135) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z - 1);
			}
			if (Camera.main.transform.eulerAngles.y > 315 || Camera.main.transform.eulerAngles.y < 45) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 225 && Camera.main.transform.eulerAngles.y < 315) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1);
			}
		}
		
	}
}