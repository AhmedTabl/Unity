﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    


 
   private void Update()
    {

        if (Input.GetKey(KeyCode.A)) {

            rigidbody.velocity = new Vector2(-5, 0);

        }else if (Input.GetKey(KeyCode.D))
        {

            rigidbody.velocity = new Vector2(5, 0);

        }
        else if (Input.GetKey(KeyCode.Space))
        {

            rigidbody.velocity = new Vector2(0, 3);

        }



    }
}
