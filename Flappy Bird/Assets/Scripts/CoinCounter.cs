using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    private float CC = 0;
    [SerializeField] private Text CoinScore;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            CC += 1;
            CoinScore.text = CC.ToString();

            Destroy(collision.gameObject);
        }
    }
}
