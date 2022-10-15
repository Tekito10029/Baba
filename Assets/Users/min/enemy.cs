using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //public Vector2 speed = new Vector2(50, 0);
    // public Vector2 speed1 = new Vector2(20, 0);
    [SerializeField] private float speed = 3f;
    [SerializeField] private Rigidbody2D rb;

    [Space(5)]
    [SerializeField] private float DSpeed = 2f;
    [SerializeField] private float DTime = 3f;

    private bool isBoostedtrue = false;
    // Start is called before the first frame update
    void Start()
    {
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

        if(!isBoostedtrue)
        {
            isBoostedtrue = true;
            Invoke("EndBoost", DTime);
        }
    }
    private void EndBoost()
    {
        isBoostedtrue = false;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Boom")
        {
            if (isBoostedtrue)
            {
                rb.velocity = transform.forward * (speed - DSpeed);
                Debug.Log("True");
            }
            else
            {
                rb.velocity = transform.forward * speed;
            }
        }
    }
}
