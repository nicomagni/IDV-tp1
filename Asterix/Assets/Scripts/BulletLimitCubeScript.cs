using UnityEngine;
using System.Collections;

public class BulletLimitCubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void isTrigger(Collider collider){
		collider.GetComponent("BulletPrefab");
		print("ENTRE" + collider);
	}
}
