using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour {

	private Transform player;
	private float speedMod = 5.0f;

	private float orgX, orgZ;

	void Start () {
		player = GameObject.Find ("Player").transform;

		//transform.LookAt(player);
		//transform.Translate(Vector3.right * Time.deltaTime);
		//transform.RotateAround(player.position, new Vector3(0.0f,1.0f,0.0f), 45);

		orgX = transform.position.x;
		orgZ = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		var camV = transform.position;
		camV.y = player.position.y + 20;
		camV.z = player.position.z -30;
		camV.x = player.position.x;
		transform.position = camV;
		//transform.LookAt(player);
		//transform.RotateAround(player.position, new Vector3(0.0f,1.0f,0.0f), 45);
		//transform.LookAt(player);
		//transform.Translate(Vector3.right * Time.deltaTime);
		//transform.RotateAround(player.position, new Vector3(0.0f,1.0f,0.0f), 20 * Time.deltaTime * speedMod);
		//Debug.Log(transform.position.x);
		//Debug.Log(player.position.x);
	
	}
}
