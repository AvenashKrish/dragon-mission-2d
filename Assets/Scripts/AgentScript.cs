using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour
{
    private float speed = 5.0f;
    private int health = 100;

    public GameObject bulletObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += move * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletObject, gameObject.transform.position, bulletObject.transform.rotation);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FireBall")
        {
            health -= 10;
            Destroy(other.gameObject);
        }
    }

    void UpdateHealth()
    {
        
        
    }

}
