using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool gameOver;

    public Sprite enemySprite;
    public Text endGameText;
    void Start(){
        gameOver = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Enemy"){
            GetComponent<SpriteRenderer>().sprite=enemySprite;
            Time.timeScale=0;
            endGameText.text="INFECTED";
            gameOver = true;
            
        }
        if(other.gameObject.tag=="Exit"){
            Time.timeScale=0;
            endGameText.text="ESCAPED";
            gameOver = true;
        }
    }

    void Update(){
        if(Input.GetKeyDown("r")){
            SceneManager.LoadScene("TestScene");
            Time.timeScale=1;
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
