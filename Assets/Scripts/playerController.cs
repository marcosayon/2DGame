using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    
    public Rigidbody2D rbody;
    public float jumpPower;
    private float moveInput;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //change the gravity so that the character can run on
        //the ceiling or floor
        if(Input.GetKeyDown(KeyCode.Space)){
            Physics2D.gravity = Physics2D.gravity * -1;
        }

        //Makes the character jump
        if(Input.GetKeyDown(KeyCode.W)){
            rbody.velocity = Vector2.up * jumpPower;
            //will check if gravity is negative. 
            //if it is, it will jump "downwards"
        }
	}
}
