using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public static int check; // Button check

    public void Mgo() //go to main scene
    {
        SceneManager.LoadScene("Main"); 
    }
    public void Lgo() // go to quiz scene
    {
        SceneManager.LoadScene("Quiz");
    }
    public void Rgo() // go to select scene
    {
        SceneManager.LoadScene("Select");
    }

    public void V1()  // go to frist movie
    {
        check = 1; 
        SceneManager.LoadScene("Movie");
    }
    public void V2() 
    {
        check = 2;
        SceneManager.LoadScene("Movie");
    }
    public void V3() 
    {
        check = 3;
        SceneManager.LoadScene("Movie");
    }
}
