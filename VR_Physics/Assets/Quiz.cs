using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    Text txt; // 퀴즈 관련 Text
    public int Level = 1; // O,X 퀴즈 단계
    int sum = 0; //퀴즈 맞춘 수

    public void correct() // O 버튼을 눌렀을 때
    {
        if (Level == 1 || Level == 3 || Level == 5) // O 버튼이 정답인 문제면
        {
            sum++;
            Level++;
        }
        else // 아닐경우에도 퀴즈 레벨은 증가
            Level++;
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
    }

    // Start is called before the first frame update
    void Start()
    {
        txt = this.GetComponent<Text>(); // 이용하려는 Text 옵션을 받는다
    }

    // Update is called once per frame
    void Update()
    {
        switch(Level) // Level 값 마다 Text 내용이 달라진다
        {
            case 1:
                txt.text = "테스트 텍스트1\n테스트 텍스트1 마무리";
                break;
            case 2:
                txt.text = "테스트 텍스트2\n테스트 텍스트2 마무리";
                break;
            case 3:
                txt.text = "테스트 텍스트3\n테스트 텍스트3 마무리";
                break;
            case 4:
                txt.text = "테스트 텍스트4\n테스트 텍스트4 마무리";
                break;
            case 5:
                txt.text = "테스트 텍스트5\n테스트 텍스트5 마무리";
                SceneManager.LoadScene("newtons");
                break;
        }
    }
}
