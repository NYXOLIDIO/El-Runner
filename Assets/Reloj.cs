using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reloj : MonoBehaviour
{
    public TMP_Text timerText;
    public bool backWards;
    [Tooltip("if")] public float time;
    private int minutes, seconds, cents;

     void Update()
    {
        if (backWards == true)
        {
            time -= Time.deltaTime;
            if (time < 0) time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }

        minutes=(int)(time/60f);
        seconds=(int)(time -minutes*60f);
        cents = (int)((time - (int)time) * 100);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
    }
}
