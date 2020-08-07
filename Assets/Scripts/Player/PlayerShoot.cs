using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    Gun playerGun;

    // Start is called before the first frame update
    void Start()
    {
        playerGun = new Pistol(bullet, transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        playerGun.Shoot();
    }
}
