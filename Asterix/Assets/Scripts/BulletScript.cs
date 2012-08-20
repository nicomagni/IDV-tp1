using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	// Update is called once per frame
	public float bulletSpeed = 10;
	
	public void launch() {
		GameObject ship = GameObject.FindGameObjectWithTag("Ship");
		Vector3 currentDirecction = ship.rigidbody.transform.forward * bulletSpeed;
		gameObject.transform.position = ship.transform.position;
		gameObject.transform.rotation = ship.transform.rotation;
		gameObject.rigidbody.velocity = ship.rigidbody.velocity;
		gameObject.rigidbody.AddForce(currentDirecction,ForceMode.Impulse);
	}

	
}
