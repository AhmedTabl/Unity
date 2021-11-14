using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCharacter : MonoBehaviour
{

    public GameObject[] characterPrefabs;
    public Transform spawnPoint;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        prefab.SetActive(true);
        //clone.GetComponent<ScoreCounter>().score = GameObject.Find("ScoreNumber").GetComponent<Text>();
       // clone.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        //clone.GetComponent<Rigidbody2D>().gravityScale = 4;
        //clone.GetComponent<Rigidbody2D>().freezeRotation = true;

    }


}
