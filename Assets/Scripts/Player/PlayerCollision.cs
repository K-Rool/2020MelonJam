using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Enemy"){
            Debug.Log("Die");
            Destroy(gameObject);
        }
    }
}
