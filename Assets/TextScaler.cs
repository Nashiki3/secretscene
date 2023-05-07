using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScaler : MonoBehaviour
{
    public Text text;
    public float scaleFactor = 1.1f;

    public void OnButtonClick()
    {
        text.fontSize = Mathf.RoundToInt(text.fontSize * scaleFactor);
    }
}
