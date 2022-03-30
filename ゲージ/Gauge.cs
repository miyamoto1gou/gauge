using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    //Sliderコーポネントを管理する用
    Slider HPbar;
    //HPを定義
    public int HP = 100;

    //現在の時間
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //HPバーを取得
        HPbar = GameObject.Find("HPbar").GetComponent<Slider>();
        //HPバーの最大値をHPにする
        HPbar.maxValue = HP;

        //HPの初期値を100に
        HPbar.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
         // クリックされたら
        if (Input.GetMouseButton(0))
           { 
            //前のフレームから経過した秒数を加算
              currentTime += Time.deltaTime;

            //毎秒処理を行う
            if (currentTime >= 1.0f)
            {
                HPbar.value -= 10;
                currentTime = 0;
            }
        }
    }
}