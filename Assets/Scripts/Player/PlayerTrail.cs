using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
    public GameObject trail;
    int i = 0;
    void FixedUpdate()
    {
        if(i%10==0){
            Debug.Log("gat");
            Instantiate(trail,new Vector3(transform.position.x, transform.position.y, 1), transform.rotation);
        }
        i++;
        
    }
}
