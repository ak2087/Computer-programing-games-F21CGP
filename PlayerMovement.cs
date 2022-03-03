using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
     
{
    public float speed = 5;
    public Rigidbody rb;
    public int jump;
    private bool Contact = true;
    public float height = 0f;

    float hInput;
    public float hMultiplayer = 2;

    
   private void FixedUpdate()
    {
        Vector3 forward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontal = transform.right * hInput * speed * Time.fixedDeltaTime * hMultiplayer;
        rb.MovePosition(rb.position + forward + horizontal);

    }
    
    

    private void Update()
    {
        hInput = Input.GetAxis("Horizontal");


        float Hmove = Input.GetAxis("Horizontal");

        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove * speed);

        if ((Input.GetKey(KeyCode.Space)) && Contact == true)
        {
            Vector3 balljump = new Vector3(0.0f, 5.0f, 0.0f);
            rb.AddForce(balljump * jump);

        }
        Contact = false;


        if (transform.position.y < height)
        {
            SceneManager.LoadScene("GameOver01");
        }



    }

    private void OnCollisionStay()
    {
        Contact = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")


        {
            other.attachedRigidbody.useGravity = false;

        }

        if (other.tag == "enemy1")
        {
            SceneManager.LoadScene("GameOver01");
        }
    }
}
