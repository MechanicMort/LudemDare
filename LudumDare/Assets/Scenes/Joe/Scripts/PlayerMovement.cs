using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemen : MonoBehaviour
{

    //control player movement speed
    public float speed;

    //access player
    public Rigidbody rb;

    //control player direction and movement
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    public bool playWithController;

    //access camera for raycast
    private Camera mainCam;

    //bool to check if player wishes to shoot
    public bool isFiring;

    //space where bullents will spawn
    public Transform[] turretLocation;





    //find camera and ridgid body for movement and raycast
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCam = FindObjectOfType<Camera>();
        isFiring = true;
    }



    // Update is called once per frame
    void Update()
    {


        //player movement and player rotation
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVelocity = moveInput * speed;



        if (!playWithController)
        {
            // rotate player with mouse if mouse is being used
            Ray camRay = mainCam.ScreenPointToRay(Input.mousePosition);
            Plane GroundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (GroundPlane.Raycast(camRay, out rayLength))
            {
                Vector3 pointToLook = camRay.GetPoint(rayLength);
                Debug.DrawLine(camRay.origin, pointToLook, Color.black);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }

            //bullet/gun check for shooting
            if (Input.GetKey(KeyCode.Space) && isFiring)
            {
                StartCoroutine(waitFire());
                Debug.Log("shoot");
            }

        }








        //rotate with controller joysticks if controller is being used

    }

    void FireMissiles()
    {
        for (int i = 0; i < turretLocation.Length; i++)
        {
            GameObject missile = OBJpool.objectInstance.GetPooledOBJ();
            if (missile != null)
            {
                missile.transform.position = turretLocation[i].position;
                missile.transform.rotation = turretLocation[i].rotation;
                missile.SetActive(true);

            }
        }
    }



    IEnumerator waitFire()
    {

        FireMissiles();
        isFiring = false;
        yield return new WaitForSeconds(1.5f);
        isFiring = true;
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}