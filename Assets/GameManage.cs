using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public int counter;
    public Text text;
    void Start()
    {
        counter = 0;
    }

    public void ButClick()
    {
        counter++;
        text.text = "Huh "+counter.ToString();
        Debug.Log(counter);
    }
}