using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public bool isHit;
    public Counter counter;
    private float minValue = 20.0f, maxValue = 70.0f;

    public void OnButtonClick()
    {
        if (((Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x) % 90) <= minValue || (Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x) % 90) >= maxValue) && !isHit)
        {
            StartCoroutine(ResetHit());
        }
    }

    public IEnumerator ResetHit()
    {
        counter.IncreaseCounter();
        isHit = true;
        yield return new WaitForSeconds(.5f);
        isHit = false;
    }
}
