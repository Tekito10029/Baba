using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHander : MonoBehaviour
{
    public static EventHander intance;
    public event Action playerDie; 
    private void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
        else
        {
            if (intance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    public void PlayerDie()
    {
        if (playerDie != null)
        {
            playerDie();
        }
    }
    
}
