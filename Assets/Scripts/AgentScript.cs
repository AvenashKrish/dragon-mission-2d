using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour
{
    private float speed = 5.0f;
    private int health = 100;

    public GameObject bulletObject;
    public GameObject heartObject;

    private bool isDisabled = false;
    private int timer = 0;

    // Use this for initialization
    void Start()
    {
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDisabled)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            transform.position += move * speed * Time.deltaTime;

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletObject, gameObject.transform.position, bulletObject.transform.rotation);
            }
        }
        
        else
        {
            timer++;

            if (timer == 100)
            {
                timer = 0;
                isDisabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FireBall")
        {
            Destroy(other.gameObject);

            if (health > 0)
            {
                health -= 20;
            }
            else
            {
                Destroy(gameObject);
            }            
        }

        else if (other.gameObject.tag == "HealthyMushroom")
        {
            if (health < 100)
            {
                health += 20;
            }
        }

        else if (other.gameObject.tag == "PoisonMushroom")
        {
            isDisabled = true;
        }

        UpdateHealth();
    }

    void UpdateHealth()
    {
        GameObject[] hearts = GameObject.FindGameObjectsWithTag("Heart");

        foreach (GameObject item in hearts)
        {
            Destroy(item);
        }
        
        int noOfHearts = health / 20;

        float pos = -4;

        for (int i = 0; i < noOfHearts; i++)
        {
            Instantiate(heartObject, new Vector3(pos += 0.5f, 5.0f), Quaternion.identity); 
        }
    }

}
