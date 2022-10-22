using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResultSceneManager : MonoBehaviour
{
    //スコアテキスト
    public Text ScoreText;
    //スコア
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //スペースキーを押した場合
        {
            SceneManager.LoadScene("Title");//GameSceneSampleシーンをロードする
        }
    }
}
