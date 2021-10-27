using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody player;
    public GameObject LoseMenu;

    [SerializeField] private float speed = 1f;
    [SerializeField] private float Turnspeed = 1f;
    private float scoreC = 0f;
    private int scoreINT = 0;

    [SerializeField] private Text score;

    private bool isRButtonPressed = false;
    private bool isLButtonPressed = false;


    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Rigidbody>();

    }


    private void Update()
    {

        player.velocity = new Vector3(player.velocity.x, player.velocity.y, speed);

        if (isRButtonPressed)
        {
            player.velocity = new Vector3(Turnspeed, player.velocity.y, player.velocity.z);
        }
        else if (!isRButtonPressed)
        {
            player.velocity = new Vector3(player.velocity.x, player.velocity.y, player.velocity.z);
        }


        if (isLButtonPressed)
        {
            player.velocity = new Vector3(-Turnspeed, player.velocity.y, player.velocity.z);
        }
        else if (!isLButtonPressed)
        {
            player.velocity = new Vector3(player.velocity.x, player.velocity.y, player.velocity.z);
        }

        scoreC += Time.deltaTime;
        scoreINT = (int)scoreC;
        score.text = scoreINT.ToString();

    }
    public void onRHold()
    {

        isRButtonPressed = true;
    }
    public void onRUP()
    {

        isRButtonPressed = false;
    }


    public void onLHold()
    {

        isLButtonPressed = true;
    }
    public void onLUP()
    {

        isLButtonPressed = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {

            LoseMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }


}
