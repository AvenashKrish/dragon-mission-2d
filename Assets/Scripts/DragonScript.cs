using UnityEngine;
using System.Collections;

public class DragonScript : MonoBehaviour {

	public GameObject fireBall;

	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("SpawnFireBall", 1.0f, 3.0f);

	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnFireBall(){

		Instantiate (fireBall, gameObject.transform.position, fireBall.transform.rotation);

	}
}
