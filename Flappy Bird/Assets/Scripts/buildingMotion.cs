using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildingMotion : MonoBehaviour
{
    public ScoreCounter sc;
    private Rigidbody2D rb;
    public Rigidbody2D bird;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



          rb.velocity = new Vector2(-10, rb.velocity.y);


    }


    }

