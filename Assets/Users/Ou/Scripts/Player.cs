using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb =>GetComponent<Rigidbody2D>();
    private BoxCollider2D boxColl2D =>GetComponent<BoxCollider2D>();
    public bool isJump;
    public bool isGround;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private int jumpNum;
    [SerializeField]
    private Transform Point;
    
    private float andPoint;
  

    // Update is called once per frame
    void Update()
    {
        AndPointDistance();
        Jump();
        CheckGround();

        this.gameObject.transform.Translate(0.25f,0,0);
    }

    private void AndPointDistance()
    {
       andPoint= Vector3.Distance(transform.position, Point.transform.position);
        if (andPoint > .2f)
        {
           transform.position = Vector3.MoveTowards(transform.position, Point.transform.position, 2f * Time.deltaTime);
        }
    }

    private void CheckGround()
    {
         isGround = boxColl2D.IsTouchingLayers(LayerMask.GetMask("Ground"));
         if (isGround)
         {
             jumpNum = 1;
             isJump = false;
         }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& jumpNum >0)
        {
            isJump = true;
            jumpNum--;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
    }
}
