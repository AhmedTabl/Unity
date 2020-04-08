using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    


 
   private void Update()
    {

        if (Input.GetKey(KeyCode.A)) {

            rigidbody.velocity = new Vector2(-8, rigidbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {

            rigidbody.velocity = new Vector2(8, rigidbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 23);

        }



    }
}
