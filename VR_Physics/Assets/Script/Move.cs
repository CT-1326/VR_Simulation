using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public static int check; // 어떤 버튼이 눌렸는지 체크하기 위한 체크 변수

    public void Mgo() // 메인 화면 버튼이 눌렸을 경우
    {
        SceneManager.LoadScene("Main"); // 메인 화면으로 돌아간다
    }
    public void Lgo()
    {
        SceneManager.LoadScene("Newtons");
    }
    public void Rgo()
    {
        SceneManager.LoadScene("Right");
    }

    public void V1() // 실험 1 버튼이 눌렸을 경우
    {
        check = 1; // 체크 변수에 1 값을 대입해 Video 씬에 쓰일 수 있게 해준다
        SceneManager.LoadScene("Movie");
    }
    public void V2()
    {
        check = 2;
        SceneManager.LoadScene("Movie");
    }
    public void V3()
    {
        check = 3;
        SceneManager.LoadScene("Movie");
    }
}
