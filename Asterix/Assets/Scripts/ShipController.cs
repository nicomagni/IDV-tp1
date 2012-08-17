using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	
	public float fowardForce = 1;
	public float breakForce = -1;
	public float deltaTorque = 1;
	
	void Update () {
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");

		if(v != 0){
			float force = Mathf.Sign(v) > 0 ? fowardForce : breakForce;
			rigidbody.AddRelativeForce(0,0,force);
		}
		
		if(h != 0){
			float torque = Mathf.Sign(h)*deltaTorque;
			rigidbody.AddRelativeTorque(0,torque,0);
		}
	}
}
