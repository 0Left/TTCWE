using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicCotrollers : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    // Update is called once per frame
    float mx;
    bool ismoving;
    private void Update(){
        mx = Input.GetAxisRaw("Horizontal");
        if( mx < 0.2f && mx > -0.2f){
            mx = 0;
        }
        if(rb.velocity.x < 0.2f && rb.velocity.x > -0.2f){
            ismoving = false;
        }else
        {
            ismoving = true;
        }
        if(Input.GetKeyDown("space")){
            raycastRight();
        }
    }
    private void FixedUpdate(){
        Vector2 movement = new Vector2( mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
        rb.rotation = 0f;
        Debug.Log(ismoving);
    }
    void raycastRight(){
        //Length of the ray
        float laserLength = 1f;

        //Get the first object hit by the ray
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, laserLength);

        //If the collider of the object hit is not NUll
        if (hit.collider != null)
        {
            //Hit something, print the tag of the object
            Debug.Log("Hitting: " + hit.collider.name);
        }

        //Method to draw the ray in scene for debug purpose
        Debug.DrawRay(transform.position, Vector2.right * laserLength, Color.red,1f);
    }
}
