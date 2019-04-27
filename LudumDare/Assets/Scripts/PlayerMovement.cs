using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemen : MonoBehaviour
{
    //private float xMove;
    //private float yMove;
    public float speed;
       
    private Rigidbody2D rb2D;
    
    void Start()
    {

        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(xMove, yMove);
        rb2D.velocity = movement * speed;
        
        
        //this.transform.Translate(new Vector3((xMove * speed * Time.deltaTime), (yMove * speed * Time.deltaTime)));
    }
}

    