using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicCotrollers : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    // Update is called once per frame
    float mx;
    private void Update(){
        mx = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate(){
        Vector2 movement = new Vector2( mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }
}
