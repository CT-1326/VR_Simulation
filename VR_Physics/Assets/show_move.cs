using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class show_move : MonoBehaviour
{
    public GameObject go;
    TextMeshPro txt;
    

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshPro>().text;
    }

    // Update is called once per frame
    void Update()
    {
        //txt.text = "X : "+go.transform.localPosition.x +"Y : "+go.transform.localPosition.y;
        txt.text="hi";
    }
}
