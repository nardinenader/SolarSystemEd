using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
      public float timeLimit = 12.0f; // Set the time limit in seconds

    private float elapsedTime = 0.0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= timeLimit)
        {
            // Application.Quit(); // Stop the game
            SceneManager.LoadScene("GameOver");
        }
    }
     
}
