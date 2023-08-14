using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class collisonDetection : MonoBehaviour
{
   
    void  OnCollisionEnter(Collision collision)
    {
        
    
         if (collision.gameObject.tag == "Player")
        {
           
              SceneManager.LoadScene("GameOver");
            
        }
           

        }
       
       
      
     
    }
    // // This function is called when a collision occurs
    // void OnCollisionEnter(Collision collision)
    // {
        
    
    //      if (collision.gameObject.tag == "Player")
    //     {
           
    //         SceneManager.LoadScene("GameOver");
           

    //     }
       
       
      
     


    


