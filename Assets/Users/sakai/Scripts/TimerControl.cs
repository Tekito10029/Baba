using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerControl : MonoBehaviour
{
    //カウントダウン
    public float countdown = 5.0f;
    int seconds;

    //時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //小数を整数に変更
        seconds = (int)countdown;
 
        //時間を表示する
        timeText.text = seconds.ToString();
 
        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");//Resultシーンをロードする。
        }
    }
}
