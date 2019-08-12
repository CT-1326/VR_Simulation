using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

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
