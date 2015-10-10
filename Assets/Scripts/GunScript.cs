using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour
{

    private Vector3 mousePosition;
    private Vector3 objectPosition;
    private float angle;
    private float bulletSpeed = 1000.0f;

    public GameObject bulletObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        mousePosition = Input.mousePosition;
        mousePosition.z = 0.0f;

        objectPosition = Camera.main.WorldToScreenPoint(transform.position);

        mousePosition.x = mousePosition.x - objectPosition.x;
        mousePosition.y = mousePosition.y - objectPosition.y;

        angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg - 90;

        Vector3 rotationVector = new Vector3(0, 0, angle);

        transform.rotation = Quaternion.Euler(rotationVector);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = (GameObject)Instantiate(bulletObject, transform.position, Quaternion.identity);
            //bullet.transform.LookAt(mousePosition);
            bullet.transform.rotation = Quaternion.Euler(new Vector3(0,0,angle + 90));
            bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.right * bulletSpeed);
        }

    }
}
