using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    public bool moveleft = false;
    public bool moveright = false;
    public bool jump = false;
    public int direction;
    public float jumpheight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    Animator playerAnimation;
    AudioSource[] sounds;
    AudioSource jumpSound;

	float h;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        sounds = this.GetComponents<AudioSource>();
        jumpSound = sounds[0];

        sounds = null;
    }

    void Update(){
		float h = Input.GetAxisRaw("Horizontal");

		if(Input.GetButtonDown("Jump") && onGround){
			Debug.Log ("jump");
			rb.velocity = new Vector2(rb.velocity.x, jumpheight);
			jump = false;
			jumpSound.Play();
		}
        
		if(h>0){
			Debug.Log (">0");
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
			rb.transform.right = Vector2.right;
			playerAnimation.SetBool("walking", true);
		}
		else if(h<0){
			Debug.Log ("<0");
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
			rb.transform.right = Vector2.left;
			playerAnimation.SetBool("walking", true);
		}
//------------------------------------------------------------------------------			


        if (moveright){
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            rb.transform.right = Vector2.right;
            playerAnimation.SetBool("walking", true);
        }

        if (moveleft){
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            rb.transform.right = Vector2.left;
            playerAnimation.SetBool("walking", true);
        }

        if(!moveleft && !moveright){
            rb.velocity = new Vector2(0, rb.velocity.y);
            playerAnimation.SetBool("walking", false);
        }
        
        if (jump && onGround == true){
            rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            jump = false;
            jumpSound.Play();
        }
    }

    void FixedUpdate(){
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
}