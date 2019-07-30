using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    Text txt; // 실험 영상 관련 Text 변수
    public GameObject View; // 실험 영상 관련 UI 오브젝트

    public void TextView()
     {
        View.SetActive(true); // Info UI 버튼이 눌렸을 때 INFO UI를 ON

        txt = GameObject.Find("Text").GetComponent<Text>(); // UI에 첨부되있는 Text 옵션 찾아 받는다

        if (Move.check == 1) // 실험 1 경우
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
        View.SetActive(false); // X 버튼이 눌렸을 땐 INFO UI를 OFF
    }
}
