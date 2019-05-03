using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    Text txt;

    public GameObject go;

    public void TextView()
     {
        go.SetActive(true);

         txt = GameObject.Find("Text").GetComponent<Text>();

         if (Move.check == 1)
         {
            txt.text = "안녕하세요\n안녕들하십니까 안녕하십니까";
         }
         else if (Move.check == 2)
         {
            txt.text = "안녕하세요2\n\n안녕들하십니까2  안녕하십니까2";
        }
         else if (Move.check == 3)
         {
            txt.text = "안녕하세요3\n\n\n안녕들하십니까3   안녕하십니까3";
        }
     }

    public void Exit()
    {
        go.SetActive(false);
    }
}
