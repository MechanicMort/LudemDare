using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemen : MonoBehaviour
{
    private float xMove;
    private float yMove;
    public float speed;

    bool isJumping;
    Rigidbody rb;

    void Awake()
    {
        isJumping = true;
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");

        this.transform.Translate(new Vector3((xMove * speed * Time.deltaTime), (yMove * speed * Time.deltaTime), 0.0f));

        //Jump();
    }

    /*
    void Jump()
    {
        if (Input.GetKeyDown("space") && isJumping == true || (Input.GetKeyDown("w") && isJumping == true))
        {
            isJumping = false;
            rb.AddForce(new Vector3(0, 20f, 0), ForceMode.Impulse);            
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
    */
}