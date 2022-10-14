using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.SearchService;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb => GetComponent<Rigidbody2D>();
    private Animator anim => GetComponent<Animator>();

    public float jumpForce;
    public int  jumpNum;
    private int jumpCurreNum;
    private float speed=10f;
    private float andPlayer;
    public Transform playerPoint;
    public LayerMask layer;
    private bool isThis;

    private CircleCollider2D _circleCollider2D=>GetComponent<CircleCollider2D>();

    private bool isGround;


    // Start is called before the first frame update
    void Start()
    {
        jumpCurreNum = jumpNum;
    }

    // Update is called once per frame
    void Update()
    {
        ChickGround();
        AndPlayer();
        if (Input.GetKeyDown(KeyCode.Space)&& jumpCurreNum >0)
        {
            anim.SetBool("IsGround",false);
            rb.velocity += Vector2.up*jumpForce;
            jumpCurreNum--;
            anim.SetTrigger("IsJump");
        }
        





        if (andPlayer > .1)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, playerPoint.position,
                speed * Time.deltaTime);
        }
       
       
        
    }

    private void ChickGround()
    {
        isGround = Physics2D.IsTouchingLayers(_circleCollider2D, layer);
      
       
        if (isGround)
        {
           
            jumpCurreNum = jumpNum;
            anim.SetBool("IsGround",true);
        }
    }

    private void AndPlayer()
    {
        andPlayer = Vector3.Distance(this.transform.position, playerPoint.transform.position);
    }

 
}