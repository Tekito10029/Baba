using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestSound : MonoBehaviour
{
   
    // Start is called before the first frame update
   public void buttonEvent()
   {
        SceneManager.LoadScene("TestSound", LoadSceneMode.Additive);
   }
}
