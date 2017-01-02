using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jagCamLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler((transform.eulerAngles.x-2*Input.GetAxis("Mouse Y")),(transform.eulerAngles.y+2*Input.GetAxis("Mouse X")),0); 
	}
}
