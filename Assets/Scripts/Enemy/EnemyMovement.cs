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
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
     {
        Vector2 direction = (target.transform.position - transform.position).normalized;
        body.MovePosition(body.position+direction*Time.fixedDeltaTime*speed);
        //body.AddForce(direction.normalized * speed, ForceMode2D.Force);
     }
     protected void LateUpdate()
 {
 }
    
}
