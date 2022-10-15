using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    //public float delay = 1f;

    //float countdown;
   // bool hasExploded = false;
    //public GameObject explosion;
    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    enemy Enemycon;
    // Start is called before the first frame update
    void Start()
    {
        // countdown = delay;
        Enemycon = Enemy.GetComponent<enemy>();
        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Debug.Log("Boom!");
            //effect
            
            //Enemycon.gimiku = true;
            //remove
            //Destroy(gameObject);
        }
    }

    
    
   
}
