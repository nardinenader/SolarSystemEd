using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

   
    
    public void correctAnswer()
    {

        Debug.Log("Good Job!");
    }
    public void wrongAnswer()
    {
         
        SceneManager.LoadScene("GameOver");
    }

    




}
