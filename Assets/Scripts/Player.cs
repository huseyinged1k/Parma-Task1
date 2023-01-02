using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] Material playerMaterial;
    public void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    public void ColorChange()
    {
        playerMaterial.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}
