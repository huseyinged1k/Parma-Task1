using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Degree : MonoBehaviour
{
    public TMP_Text degreeText;
    public float playerXRot = 0;

    
    private void Update()
    {
        playerXRot = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x) % 90;
        degreeText.text = playerXRot.ToString();
    }
}
