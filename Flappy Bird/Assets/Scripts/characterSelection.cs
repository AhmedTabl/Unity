using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterSelection : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int selectedCharacter = 0;

    public void nextCharacter() {

        selectedCharacter = (selectedCharacter + 1) % sprites.Length;
        anim.SetInteger("characterAnim", selectedCharacter);
    
    }

    public void previousCharacter()
    {

        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += sprites.Length;

        }
        anim.SetInteger("characterAnim", selectedCharacter);

    }

    public void select()
    {

        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene("MainMenu");

    }
}
