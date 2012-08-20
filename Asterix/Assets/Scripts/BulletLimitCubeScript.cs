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
		//The bullets are going out
		BulletManagerScript bulletManagerScript = (BulletManagerScript) GameObject.FindGameObjectWithTag("BulletManager").GetComponent(typeof(BulletManagerScript));
		bulletManagerScript.DisableBullet(collider.gameObject);
	}
	
}
