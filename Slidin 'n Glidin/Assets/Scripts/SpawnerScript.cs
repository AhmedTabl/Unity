using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    private Rigidbody rb;

    private float timer = 0f;
    private float maxTime = 0.25f;

    private float timer2 = 0f;
    private float maxTime2 = 200f;

    [SerializeField] private GameObject obs;
    [SerializeField] private GameObject gr;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 100);

        if (timer > maxTime)
        {
            GameObject newObs = Instantiate(obs);
            newObs.transform.position = new Vector3(Random.Range(-12f, 26f), rb.transform.position.y, rb.transform.position.z);
            newObs.transform.localScale = new Vector3(newObs.transform.localScale.x, newObs.transform.localScale.y, Random.Range(3f, 20f));
            Destroy(newObs, 100);

            timer = 0f;
        }

        if (timer2 > maxTime2)
        {
            GameObject newgr = Instantiate(gr);
            newgr.transform.position = new Vector3(7.1f, -4, rb.transform.position.z);
            Destroy(newgr, 1000);

            timer2 = 0f;
        }


        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
    }
}
