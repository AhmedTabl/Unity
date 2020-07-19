﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Inspector variables
    [SerializeField] private KeyCode jumpButton;
    [SerializeField] private float Speed;
    [SerializeField] private float jumpForce;

    //Refrences
    private Rigidbody2D rb;
    private MenuButtons Menu;
    private AudioSource jumpSound;

    //Other Variables


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Menu = GetComponent<MenuButtons>();
        jumpSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        rb.velocity = new Vector2(Speed,rb.velocity.y);

        if (Input.GetKeyDown(jumpButton))
        {
            jump();
        }
    }
    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        jumpSound.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {

            Menu.victoryMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }
    
}
