using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{

    public GameObject[] mushroomObjects;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnMushroom", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {        
                
    }

    void SpawnMushroom()
    {
        float randomNum = UnityEngine.Random.Range(0, mushroomObjects.Length);
        int selectedIndex = (int)randomNum;

        float posX = Random.Range(-10, 10);
        float posY = gameObject.transform.position.y;

        Instantiate(mushroomObjects[selectedIndex], new Vector3(posX, posY, 0), Quaternion.identity);
    }

}
