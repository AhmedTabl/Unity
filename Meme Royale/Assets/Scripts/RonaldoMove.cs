using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RonaldoMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);

        if (Input.GetKeyDown(KeyCode.E)) {

            anim.SetTrigger("kick");

        }
       
        
    }
}
