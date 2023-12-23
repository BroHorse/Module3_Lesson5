using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds;
    public string sceneName;

    private void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds > 0 )
        {
            print("Осталось: "+ seconds );
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
