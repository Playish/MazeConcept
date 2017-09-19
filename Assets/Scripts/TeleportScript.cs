using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rot = transform.rotation;
		rot.y = transform.rotation.y * Time.deltaTime * 3.0f;
		transform.rotation = rot;
	}
}
