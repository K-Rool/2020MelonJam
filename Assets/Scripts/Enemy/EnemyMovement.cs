using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    public GameObject target;
    Vector3 position;
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color32((byte)Random.Range(100,255),(byte)Random.Range(70,255),(byte)Random.Range(70,255), 255);
        body = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
     {
         if(!PlayerCollision.gameOver){
            Vector2 direction = (target.transform.position - transform.position).normalized;
            body.MovePosition(body.position+direction*Time.fixedDeltaTime*speed);
         }
     }
     protected void LateUpdate()
 {
 }
    
}
