using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    Text txt; // 퀴즈 관련 Text
    static int Level = 1; // O,X 퀴즈 단계...고정 값(static)으로 선언해야 값이 o,x 퀴즈 상황에 맞게 고정된다
    static int sum = 0; //퀴즈 맞춘 수...level과 마찬가지로 고정 값 선언
    float time = 5f; // 타이머 변수

    public void correct() // O 버튼을 눌렀을 때
    {
        if (Level == 1 || Level == 3 || Level == 5) // O 버튼이 정답인 문제면
        {
            sum++;
            Level++;
        }
        else // 아닐경우에도 퀴즈 레벨은 증가
            Level++;

        StartCoroutine(show_text());
    }
    public void wrong() // X 버튼을 눌렀을 때
    {
        if(Level == 2 || Level == 4)
        {
            sum++;
            Level++;
        }
        else
            Level++;

        StartCoroutine(show_text());
    }

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>(); // Text 옵션을 찾아 이용하게 받는다
        txt.text = "테스트 텍스트1\n테스트 텍스트1 마무리";
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator show_text()
    {
        switch (Level) // Level 값 마다 Text 내용이 달라진다
        {
            case 2:
                txt.text = "테스트 텍스트2\n테스트 텍스트2 마무리";
                Debug.Log("2");
                break;
            case 3:
                txt.text = "테스트 텍스트3\n테스트 텍스트3 마무리";
                Debug.Log("3");
                break;
            case 4:
                txt.text = "테스트 텍스트4\n테스트 텍스트4 마무리";
                Debug.Log("4");
                break;
            case 5:
                txt.text = "테스트 텍스트5\n테스트 텍스트5 마무리";
                Debug.Log("5");
                break;
            default:
                txt.text = "정답 수 : " + sum + "\n체험존으로 5초 뒤 이동합니다";
                Debug.Log("other");
                StartCoroutine(ch_time());
                break;
        }
        yield return null;
    }

    IEnumerator ch_time()
    {
        while(true)
        {
            time -= Time.deltaTime;
            Debug.Log(time);
            if (time < 0) // 타이머가 0초로 넘어가면 뉴턴 씬으로 넘어간다
                SceneManager.LoadScene("Newtons");
            yield return null;

        }     
    }
}
