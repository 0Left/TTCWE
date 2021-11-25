using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior01 : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    float mx;
    private void Start(){
        mx = -1f;
        InvokeRepeating("flipFlopDirection",1f,1f);
    }
    bool isGoingRight;
    private void flipFlopDirection(){
        if(isGoingRight){
            mx = -1f;
            isGoingRight = false;
        }else
        {
            mx = 1f;
            isGoingRight = true;
        }
    }
    private void FixedUpdate(){
        Vector2 movement = new Vector2( mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
        rb.rotation = 0f;
        transform.rotation = Quaternion.Euler(0, gameObject.transform.eulerAngles.y, 0);


    }
}
