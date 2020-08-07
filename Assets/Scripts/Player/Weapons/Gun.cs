using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform objTransform;
    public float timeBetweenShots;
    public float timeUntilNextShot;

    public Gun(GameObject bullet, Transform transform){
        this.bullet=bullet;
        this.objTransform = transform;
    }

    public virtual void Shoot(){
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
