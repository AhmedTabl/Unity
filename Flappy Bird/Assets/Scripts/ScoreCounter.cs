using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text score;
    private int scoreCounter = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreReciever")
        {
            scoreCounter += 1;
            score.text = scoreCounter.ToString();
        }
    }
}
