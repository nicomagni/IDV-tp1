using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

	float xRotation, yRotation, zRotation;
	float xMove, zMove;

	// Use this for initialization
	void Start () {

	}
	
	void OnEnable() {
		float cameraSize = (float) Camera.main.camera.orthographicSize + 1.0f;
		float xPos, zPos;

		float randX = (float) UnityEngine.Random.Range(1.0f, 2.0f);
		float randZ = (float) UnityEngine.Random.Range(1.0f, 2.0f);
		
		// Choose a random spot to spawn, always on a camera border
		float randomBorder = UnityEngine.Random.Range(0.0f, 1.0f);
		if(randomBorder < 0.5f) {
			xPos = (float) UnityEngine.Random.Range(-cameraSize, cameraSize);
			zPos = randomBorder > 0.25f ? -cameraSize : cameraSize;
			zMove = randomBorder > 0.25f ? randZ : -randZ;
			xMove = UnityEngine.Random.Range(0.0f, 1.0f) > 0.5f ? randX : -randX;
		} else {
			zPos = (float) UnityEngine.Random.Range(-cameraSize, cameraSize);
			xPos = randomBorder > 0.75f ? -cameraSize : cameraSize;
			xMove = randomBorder > 0.75f ? randX : -randX;
			zMove = UnityEngine.Random.Range(0.0f, 1.0f) > 0.5f ? randZ : -randZ;
		}
		
		Debug.Log("cameraSize: " + cameraSize);
		
		this.transform.position = new Vector3(xPos, 0, zPos);
				
		// Choose random torque
		float torqueLimit = 8.0f;
		xRotation = (float) UnityEngine.Random.Range(-torqueLimit, torqueLimit);
		yRotation = (float) UnityEngine.Random.Range(-torqueLimit, torqueLimit);
		zRotation = (float) UnityEngine.Random.Range(-torqueLimit, torqueLimit);
		
		Debug.Log(xMove + " " + zMove);
		
//		float magnitude = 1000000000.0f;
//		this.rigidbody.AddRelativeForce(new Vector3(xMove * magnitude, 0, zMove * magnitude));		
//		transform.TransformDirection(new Vector3(xMove, 0, zMove));
//		this.rigidbody.AddTorque(xRotation * magnitude, yRotation * magnitude, zRotation* magnitude);
	}
 	
	// Update is called once per frame
	void Update () {
		
		// Deactivate the enemy bug if it reachs a camera border
		float cameraSize = (float) Camera.main.camera.orthographicSize + 3.0f;
		if(this.transform.position.z < -cameraSize || this.transform.position.z > cameraSize ||
			this.transform.position.x < -cameraSize || this.transform.position.x > cameraSize) {
			this.gameObject.active = false;
		}
		
		this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
		this.rigidbody.AddRelativeForce(new Vector3(xMove, 0, zMove));
		this.rigidbody.AddTorque(xRotation, yRotation, zRotation);
	}
}
