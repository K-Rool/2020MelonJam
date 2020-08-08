using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed;
    private Vector2 moveVelocity;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    void Update ()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized*runSpeed;

    }

    private void FixedUpdate()
    {  
        if(!PlayerCollision.gameOver){
          body.MovePosition(body.position+moveVelocity*Time.fixedDeltaTime);
        }
    }

    private void LateUpdate()
    {
        if(!PlayerCollision.gameOver){
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
        }
    }
}
