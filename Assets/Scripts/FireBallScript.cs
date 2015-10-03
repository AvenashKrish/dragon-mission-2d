using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour {

	private float speed = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (new Vector3 (0, 0, 15.0f));

		gameObject.transform.Translate (-1 * speed * Time.deltaTime, 0, 0, Space.World);

	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == "Player") {
			
			Destroy(gameObject);
			Debug.Log("Trigger Enter");
			
		}
		
	}
}
