using UnityEngine;
using System.Collections;

public class BulletLimitCubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerExit(Collider collider){
		collider.GetComponent("BulletPrefab");
		print("ENTRE EXIT" + collider);
	}
	
}
