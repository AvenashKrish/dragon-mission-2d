using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour {

	private float speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (new Vector3 (0, 0, 15.0f));

		gameObject.transform.Translate (-1 * speed * Time.deltaTime, 0, 0, Space.World);

	}

}
