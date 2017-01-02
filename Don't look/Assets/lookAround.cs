using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		//transform.rotation = Quaternion.Euler(Input.mousePosition);

		Camera.main.transform.rotation = Quaternion.Euler((Camera.main.transform.eulerAngles.x-2*Input.GetAxis("Mouse Y")),(Camera.main.transform.eulerAngles.y+2*Input.GetAxis("Mouse X")),0);
	}
}
