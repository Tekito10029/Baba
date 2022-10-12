using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Experimental.Playables;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb => GetComponent<Rigidbody2D>();

    public float jumpForce;

    public float jumpNum;
    private float speed=10f;
    private float andPlayer;
    public Transform playerPoint;
    public LayerMask layer;

    private CircleCollider2D _circleCollider2D=>GetComponent<CircleCollider2D>();

    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AndPlayer();
        if (Input.GetKeyDown(KeyCode.Space)&&jumpNum >0)
        {
            rb.velocity += Vector2.up*jumpForce;
            jumpNum--;
        }

        if (andPlayer > .1)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, playerPoint.position,
                speed * Time.deltaTime);
        }
        
        ChickGround();
    }

    private void ChickGround()
    {
        isGround = Physics2D.IsTouchingLayers(_circleCollider2D, layer);
        if (isGround)
        {
            jumpNum = 1;
        }
    }

    private void AndPlayer()
    {
        andPlayer = Vector3.Distance(this.transform.position, playerPoint.transform.position);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
    }
}
