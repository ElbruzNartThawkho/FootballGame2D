using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text Score;
    void Start()
    {
        Score = GetComponent<Text>();
    }
    void Update()
    {
        Score.text = "" + scoreValue;
    }
}
