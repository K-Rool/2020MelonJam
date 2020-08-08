using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public GameObject door;
    public GameObject cover;

    public GameObject[] enemies;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
        Debug.Log(enemies.Length);
            door.SetActive(false);
            cover.SetActive(false);
            for(int i=0; i<enemies.Length; i++){
                Debug.Log(enemies[i]+" "+i);
                enemies[i].SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
    
}
