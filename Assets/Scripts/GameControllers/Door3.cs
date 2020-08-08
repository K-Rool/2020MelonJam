using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door3 : MonoBehaviour
{
    public Text endGameText;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            Time.timeScale=0;
            endGameText.text="ESCAPED";
            PlayerCollision.gameOver = true;
        }
    }
}
