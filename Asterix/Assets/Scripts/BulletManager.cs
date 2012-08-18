using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {
	
	public int maxBullets = 100;
	public GameObject bulletPrefab;	
	Stack usedBullets;
	Stack unUsedBullets;
	
		// Use this for initialization
	void Start () {
		usedBullets = new Stack(maxBullets);
		unUsedBullets = new Stack(maxBullets);
		for(int i = 0; i < maxBullets; i++){
			GameObject bullet = Instantiate(bulletPrefab) as GameObject;
			bullet.SetActiveRecursively(false);
			unUsedBullets.Push(bullet);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space)){
			if(unUsedBullets.Peek() != null){
				GameObject unUsedBullet = (GameObject)unUsedBullets.Pop();
				unUsedBullet.SetActiveRecursively(true);
				BulletScript bullet = (BulletScript) unUsedBullet.GetComponent(typeof(BulletScript));
				bullet.launch();
				usedBullets.Push(unUsedBullet);
			}
		}
	}	
	
}
