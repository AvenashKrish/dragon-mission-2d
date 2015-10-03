using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour
{
    private float speed = 5.0f;
    private int health = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += move * speed * Time.deltaTime;

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "FireBall")
        {

            Destroy(other.gameObject);
            Debug.Log("Trigger Enter");

        }

    }

    /*
    void OnCollisionEnter2D(Collision2D coll) {

        if (coll.gameObject.tag == "FireBall") {

            Destroy(gameObject);
            Debug.Log("Collision Enter");
			
        }

    }
    */
}
