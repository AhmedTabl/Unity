using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text score;
    public int scoreCounter = 0;
    public int speed = -10;

    public Rigidbody2D building;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreReciever")
        {
            scoreCounter += 1;

            speed -= 1;
            //building.velocity = new Vector2(speed, building.velocity.y);

            score.text = scoreCounter.ToString();
        }
    }


}