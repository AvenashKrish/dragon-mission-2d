using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{

    float speed = 25.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FireBall")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        //Destroy(gameObject);
    }
}
