using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Reset()
    {
        RedScore.scoreValue = 0;
        BlueScore.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
