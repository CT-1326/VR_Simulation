using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;
    public GameObject go3;

    public void show()
    {
        go2.SetActive(false);
        go3.SetActive(false);
        go.SetActive(true);
    }

    public void exit()
    {
        go.SetActive(false);
        go2.SetActive(true);
        go3.SetActive(true);
    }
}
