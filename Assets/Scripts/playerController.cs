using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
    
    public Rigidbody2D rbody;
    public float jumpPower;
    private float moveInput;

    public Collider2D floor;
    public Collider2D ceiling;
    private Collider2D myCollider;
    public Collider2D[] saws;

    public bool grounded;
    public bool ceilingGrounded;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

        for (var i = 0; i < saws.Length; i++){
            if(myCollider.IsTouching(saws[i])){
                SceneManager.LoadScene("Menu");
            }
        }

        grounded = myCollider.IsTouching(floor);
        ceilingGrounded = myCollider.IsTouching(ceiling);
        //
        transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        transform.rotation = Quaternion.identity; //used to stabalize rotation

        //change the gravity so that the character can run on
        //the ceiling or floor
        if(Input.GetKeyDown(KeyCode.Space)){
            //will change gravity
            Physics2D.gravity = Physics2D.gravity * -1;

            //this will flip the character upside down when gravity is
            //changed.
            Vector3 newScale = this.transform.localScale;
            newScale.y *= -1;
            this.transform.localScale = newScale;

        }

        //Makes the character jump
        if(Input.GetKeyDown(KeyCode.W)){
            //rbody.velocity = Vector2.up * jumpPower;
            //will check if gravity is negative
            if (this.transform.localScale.y < 0)
            {
                if (ceilingGrounded)
                {
                    rbody.velocity = Vector2.down * jumpPower;
                }
            }
            else if (this.transform.localScale.y > 0)
            {
                if (grounded)
                {
                    rbody.velocity = Vector2.up * jumpPower;
                }
            }
            //if it is, it will jump "downwards"
        }
	}
}
