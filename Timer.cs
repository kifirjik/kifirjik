using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minuts;
    public float second;
    void Update()
    {
        second -= Time.deltaTime;
        if (second <= 0)
        {
            if (minuts > 0)
            {
                second += 59;
                minuts -= 1;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }


        }

    }
}
