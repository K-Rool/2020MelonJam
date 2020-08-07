using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{

    public Pistol(GameObject bullet, Transform transform): base(bullet, transform)
    {
        timeBetweenShots = .5f;
    }

    public override void Shoot(){
        if(Input.GetMouseButtonDown(0)&&timeUntilNextShot<=0){
            Instantiate(bullet, objTransform.position, objTransform.rotation);
            timeUntilNextShot=timeBetweenShots;
        }
        timeUntilNextShot-=Time.deltaTime;
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
