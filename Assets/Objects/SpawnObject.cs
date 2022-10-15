using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    int nowtime = 0;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        //
    }
    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            nowtime += 1;
            Debug.Log(nowtime);
            if(nowtime % 5 == 0)
                Spawn(); 
        }
    }

    void Spawn()
    {
        Instantiate(obj, new Vector3(2.0f, 0, 0), Quaternion.identity);
    }
}
