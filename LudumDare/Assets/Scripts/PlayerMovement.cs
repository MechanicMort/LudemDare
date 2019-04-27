using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xMove;
    private float yMove;
    public float speed;


    public bool isFiring;
    public Camera mainCam;
    public Rigidbody2D rb;

   

    void Start()
    {

        isFiring = true;
        mainCam = FindObjectOfType<Camera>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
        
        Vector2 MovementDirection = new Vector2(xMove, yMove);

        rb.velocity = MovementDirection * speed * Time.deltaTime;

        rotateAround();

    }

    void rotateAround()
    {
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookAt = mouseScreenPosition;

        float AngleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg - 90);
    }

        IEnumerator waitFire()
    {

        //FireMissiles();
        isFiring = false;
        yield return new WaitForSeconds(1.5f);
        isFiring = true;
    }

}