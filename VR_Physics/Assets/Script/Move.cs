using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public static int check;

    public void Mgo()
    {
        SceneManager.LoadScene("Main");
    }
    public void Lgo()
    {
        SceneManager.LoadScene("Newtons");
    }
    public void Rgo()
    {
        SceneManager.LoadScene("Right");
    }

    public void V1()
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
