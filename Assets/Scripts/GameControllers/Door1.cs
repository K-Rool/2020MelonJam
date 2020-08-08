using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public GameObject door;
    public List<GameObject> enemies;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            door.SetActive(true);
            StartCoroutine("SpawnEnemies");
        }
    }
    IEnumerator SpawnEnemies()
    {
        for(int i=0; i<enemies.Count; i++){
            enemies[i].SetActive(true);
            yield return new WaitForSeconds(.5f);
        }
    }
}
