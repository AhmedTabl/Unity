using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{

    public Animator anim;
    public Transform spawnPoint;


    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        anim.SetInteger("characterAnim", selectedCharacter);
        /*        GameObject prefab = characterPrefabs[selectedCharacter];
                GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
                clone.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                clone.GetComponent<Rigidbody2D>().gravityScale = 4;
                clone.GetComponent<Rigidbody2D>().freezeRotation = true;*/

    }


}
