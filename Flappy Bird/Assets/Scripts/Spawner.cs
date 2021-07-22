using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1f;
    public float timer = 0f;
    public GameObject building;
    public GameObject bird;

    // Update is called once per frame
    void Update()
    {


        if (timer > maxTime)
        {
          
            GameObject newbuilding = Instantiate(building);
            newbuilding.transform.position = transform.position + new Vector3(25f, Random.Range(-20, 7.5f), 0);
            Destroy(newbuilding, 40);

            GameObject newBird = Instantiate(bird);
            newBird.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, newBird.GetComponent<Rigidbody2D>().velocity.y);
            newBird.transform.position = transform.position + new Vector3(45f, Random.Range(25f, 44f), newBird.GetComponent<Transform>().position.z);
            Destroy(newBird, 40);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
