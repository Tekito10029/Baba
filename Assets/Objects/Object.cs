using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Object : MonoBehaviour
{
    public UnityEvent m_event;

    void OnTriggerEnter(Collider other)
    {
        m_event.Invoke();
        Debug.Log("OK");
    }
}
