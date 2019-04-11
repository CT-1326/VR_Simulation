using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;
    public GameObject go3;
    // Start is called before the first frame update
    void Start()
    {
        if(Move.check==1)
        {
            go.SetActive(true);
        }
        else if (Move.check == 2)
        {
            go2.SetActive(true);        
        }
        else if (Move.check == 3)
        {
            go3.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
