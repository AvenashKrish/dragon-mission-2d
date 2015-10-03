using UnityEngine;
using System.Collections;

public class DragonScript : MonoBehaviour {
    
    public GameObject fireBall;
    private int health = 100;

	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("SpawnFireBall", 1.0f, 2.0f);

	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnFireBall(){

        Instantiate(fireBall, gameObject.transform.position, fireBall.transform.rotation);
        
        if (health < 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            health -= 5;
            Destroy(other.gameObject);
        }
    }

}
