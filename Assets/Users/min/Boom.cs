using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    //public float delay = 1f;

    //float countdown;
   // bool hasExploded = false;
    //public GameObject explosion;
    
     public GameObject explosion;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Debug.Log("Boom!");
            //effect
            Instantiate(explosion, transform.position, transform.rotation); 
           
        }
    }

    
    
   
}
