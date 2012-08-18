using UnityEngine;
using System.Collections;

public class AsteroidManager : MonoBehaviour {

	GameObject[] enemyBugs;

	public int enemyBugCache = 20;
	public float randLimit = 95.0f;
	
	// Use this for initialization
	void Start () {
		enemyBugs = new GameObject[enemyBugCache];

		for(int i = 0; i < enemyBugs.Length; i++){
			enemyBugs[i] = (GameObject) Instantiate(Resources.Load("AsteroidPrefab"));
			enemyBugs[i].active = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		float rand = UnityEngine.Random.Range(0.0f, 100.0f);
		if(rand > randLimit) {
			
	        for(int i = 0; i < enemyBugs.Length; i++){
				if(enemyBugs[i].active == false) {
					enemyBugs[i].active = true;
					break;
				}
	        }

		}	
	}
}
