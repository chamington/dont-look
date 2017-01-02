using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w")) {
			if (Camera.main.transform.eulerAngles.y > 45 && Camera.main.transform.eulerAngles.y < 135) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + 1, Camera.main.transform.position.y, Camera.main.transform.position.z);
			}
			if (Camera.main.transform.eulerAngles.y > 315 || Camera.main.transform.eulerAngles.y < 45) {
				Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1);
			}
			if (Camera.main.transform.eulerAngles.y > 225 && Camera.main.transform.eulerAngles.y < 315) {
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