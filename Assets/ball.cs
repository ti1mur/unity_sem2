using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Text text;
    public int count = 100;
    private void OnCollisionEnter(Collision collision)
    {
        count--;
        text.text = count.ToString();
    }
}
