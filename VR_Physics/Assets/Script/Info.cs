using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    Text txt; 
    public GameObject View;  // Info UI

    public void TextView()
     {
        View.SetActive(true); // Info UI turn on

        txt = GameObject.Find("Text").GetComponent<Text>(); 

        if (Move.check == 1) // when first movie info is
        {
            txt.text = "test\n\ntest1";
        }
        else if (Move.check == 2)
        {
            txt.text = "test\n\nest2";
        }
        else if (Move.check == 3)
        {
            txt.text = "test\n\ntest3";
        }
    }

    public void Exit()
    {
        View.SetActive(false); // Info UI turn off
    }
}
