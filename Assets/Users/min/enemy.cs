using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class enemy : MonoBehaviour
{
    //public Vector2 speed = new Vector2(50, 0);
    // public Vector2 speed1 = new Vector2(20, 0);
    private float speed;
    private float boostTimer;
    public bool decreasing;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        boostTimer = 0;
        decreasing = false;
        if(rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Hoz1");
        Vector3 movement = new Vector3(speed * inputX, 0, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);
        
        if(decreasing)
        {
            boostTimer += Time.deltaTime;
            if(boostTimer >= 3)
            {
                speed = 10;
                boostTimer = 0;
                decreasing = false;
            }
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boom")
        {
            decreasing = true;
            speed = 3;
            Destroy(other.gameObject);
        }
    }
}
