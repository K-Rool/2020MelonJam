using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunUpgrade : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"){
            PlayerShoot ps = player.GetComponent<PlayerShoot>();
            ps.playerGun = new Shotgun(ps.bullet, ps.transform);
            gameObject.SetActive(false);
        }
    }
}
