using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public GameObject video; // 비디오를 담고 있는 오브젝트
    public GameObject video2;
    public GameObject video3;

    void Start()
    {
        if (Move.check == 1) // 앞 전 씬에서 체크 변수가 1일 경우 즉 실험 1 버튼이 눌렸을 떄      
            video.SetActive(true); // 
        
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
