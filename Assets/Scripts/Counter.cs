using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Counter : MonoBehaviour
{
    public static Counter Instance;
    public TMP_Text counterText;

    public int counterValue = 0;

    public void Awake()
    {
        Instance = this;
    }

    public void IncreaseCounter()
    {
        counterValue += 1;
        counterText.text = counterValue.ToString();
        Player.Instance.ColorChange();
    }
}
