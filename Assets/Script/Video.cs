using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/*
 video url : https://www.youtube.com/watch?v=fXZpc1r9jfY
 video2 url : https://www.youtube.com/watch?v=QuFztGq-C4w
 video3 url : https://www.youtube.com/watch?v=A0zkd8Mv3ik&t=3s
*/

public class Video : MonoBehaviour
{
    public GameObject video; // Movie
    public GameObject video2;
    public GameObject video3;

    void Start()
    {
        if (Move.check == 1)    
            video.SetActive(true); // turn on first movie
        
        else if (Move.check == 2)
            video2.SetActive(true); 

        else if (Move.check == 3)
            video3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
