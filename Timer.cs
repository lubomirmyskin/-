using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;

public class Timer : MonoBehaviour
{
    int minute = 1;
    float second = 0.01f;
    public string sceneName;

    public void Update()
    {
        second -= Time.deltaTime;

        if (second == 0)
        {
            if (minute > 0)
            {
                minute -= 1;
                second += 0.59f;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }   
        
        

    }
}
