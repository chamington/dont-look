using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject moveWall = GameObject.FindWithTag("movingWall");
		if (moveWall.transform.position.y < 7 && Camera.main.transform.position.x > moveWall.transform.position.y) {
			transform.position = new Vector3 (transform.position.x, 15, transform.position.z);
		}
	}
}
