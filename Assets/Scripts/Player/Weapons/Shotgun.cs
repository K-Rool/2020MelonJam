using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    
    public Shotgun(GameObject bullet, Transform transform): base(bullet, transform)
    {
        timeBetweenShots = 1;
    }
    public override void Shoot(){
        if(Input.GetMouseButtonDown(0)&&timeUntilNextShot<=0){
            Instantiate(bullet, objTransform.position, objTransform.rotation);
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,5));
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,10));
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,15));
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,-5));
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,-10));
            Instantiate(bullet, objTransform.position, objTransform.rotation * Quaternion.Euler(0,0,-15));
            timeUntilNextShot=timeBetweenShots;
        }
        timeUntilNextShot-=Time.deltaTime;
    }
}
