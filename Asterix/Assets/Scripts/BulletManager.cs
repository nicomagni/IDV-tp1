using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {
	
	public int maxBullets = 100;
	public GameObject bulletPrefab;	
	ArrayList usedBullets;
	ArrayList unUsedBullets;
	
		// Use this for initialization
	void Start () {
		usedBullets = new ArrayList(maxBullets);
		unUsedBullets = new ArrayList(maxBullets);
		for(int i = 0; i < maxBullets; i++){
			GameObject bullet = Instantiate(bulletPrefab) as GameObject;
			bullet.SetActiveRecursively(false);
			unUsedBullets.Add(bullet);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space)){
			if(unUsedBullets.Count > 0){
				GameObject unUsedBullet = (GameObject)unUsedBullets[1];
				unUsedBullet.SetActiveRecursively(true);
				BulletScript bullet = (BulletScript) unUsedBullet.GetComponent(typeof(BulletScript));
				bullet.launch();
				usedBullets.Add(unUsedBullet);
				unUsedBullets.Remove(unUsedBullet);
			}
		}
	}	
	
}
