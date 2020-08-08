using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 5;
    public float lifespan = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.up * speed;
        GameObject[] noCollide = GameObject.FindGameObjectsWithTag("Bullet");
        for(int i=0; i<noCollide.Length; i++){
            Physics2D.IgnoreCollision(noCollide[i].GetComponent<Collider2D>(),this.GetComponent<Collider2D>());
        }
            Physics2D.IgnoreCollision(GameObject.FindWithTag("Player").GetComponent<Collider2D>(),this.GetComponent<Collider2D>());
    }
    void Update(){
        lifespan-=Time.deltaTime;
        if(lifespan<=0){
            Destroy(this);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("buletcoldi");
        if(other.gameObject.tag=="Enemy"){
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
