using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jaggedCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var radAngle = Camera.main.fieldOfView * Mathf.Deg2Rad;
		var radHFOV = 2 * Mathf.Atan(Mathf.Tan(radAngle / 2) * Camera.main.aspect);
		var hFOV = Mathf.Rad2Deg * radHFOV;
		print (hFOV);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject camEffect = GameObject.FindWithTag("camEf");
		Camera.main.transform.rotation = Quaternion.Euler(Mathf.Round(camEffect.transform.eulerAngles.x/10)*10,Mathf.Round(camEffect.transform.eulerAngles.y/10)*10,0);
	}
}
