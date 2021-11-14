using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    private float speed =-10;

    public float maxTime = 1f;
    public float timer = 0f;

    private float maxTime2 = 2f;
    private float timer2 = 0f;

    private float maxTime4 = 5f;
    private float timer4 = 0f;

    private float timer3 = 0f;
    private float b = 0f;
    private float a = 0f;

    public GameObject building;
    public GameObject bird;
    public GameObject coin;

    public ScoreCounter sc;

    // Update is called once per frame
    void Update()
    {

        if (timer4 > maxTime4)
        {
            GameObject newCoin = Instantiate(coin);
            newCoin.GetComponent<Rigidbody2D>().velocity = new Vector2(-15, newCoin.GetComponent<Rigidbody2D>().velocity.y);
            newCoin.transform.position = transform.position + new Vector3(45f, Random.Range(27f, 44f), newCoin.GetComponent<Transform>().position.z);
            Destroy(newCoin, 40);

            timer4 = 0;
        }


        if (timer2 > maxTime2)
        {
            GameObject newBird = Instantiate(bird);
            newBird.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, newBird.GetComponent<Rigidbody2D>().velocity.y);
            newBird.transform.position = transform.position + new Vector3(45f, Random.Range(28f, 44f), newBird.GetComponent<Transform>().position.z);
            Destroy(newBird, 40);

            timer2 = 0;
        }



        if (timer > maxTime)
        {

            float buildVel = -10f;
            GameObject newbuilding = Instantiate(building);
            newbuilding.transform.position = transform.position + new Vector3(25f, Random.Range(-20, 7.5f), 0);
            Destroy(newbuilding, 40);

            timer = b;
            a++;
            if (a == 5) {

                buildVel -= 20;
                //newbuilding.GetComponent<Rigidbody2D>().velocity = new Vector2(buildVel, newbuilding.GetComponent<Rigidbody2D>().velocity.y);
            }
        }

        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        timer4 += Time.deltaTime;

        if (timer3 >= 2)
        {
            b += 0.05f;
            timer3 = 0f;
        }

    }

}
