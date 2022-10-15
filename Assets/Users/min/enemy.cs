using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class enemy : MonoBehaviour
{
    //public Vector2 speed = new Vector2(50, 0);
    // public Vector2 speed1 = new Vector2(20, 0);
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    [Space(5)]
    [SerializeField] private float DSpeed = 9f;
    [SerializeField] private float DTime = 3f;
    [SerializeField] public bool decreasing;
    [SerializeField] public bool gimiku;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        gimiku = false;
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

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name =="Boom")
        {
            Debug.Log("Touching");
            Instantiate(explosion, transform.position, transform.rotation);
            if (gimiku)
            {
                if (decreasing)
                {
                    speed = speed - DSpeed;
                }
            }
            if (!decreasing)
            {
                Debug.Log("Decreasing the speed");
                decreasing = true;
                Invoke("EndDecrease", DTime);
            }
        }
    }
    private void EndDecrease()
    {
        decreasing = false;
    }
    
           
            
        
 
}
