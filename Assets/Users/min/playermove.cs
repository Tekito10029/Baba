using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    //public Vector2 speed = new Vector2(50, 50);
    [SerializeField]
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        

        Vector3 movement = new Vector3(speed * inputX, 0 ,0);
        movement *= Time.deltaTime;

        transform.Translate(movement);
    }

    
}
