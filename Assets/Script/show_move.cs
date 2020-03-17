using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class show_move : MonoBehaviour
{
    public GameObject player; // VR 기능이 달린 캐릭터 오브젝트
    TextMeshProUGUI txt; // 이동 값을 표현하는 Text mesh 변수
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>(); // Text Mesh Pro 오브젝트 받기
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Z : " + player.transform.localPosition.z.ToString("N2"); // 플레이어의 Z 값 실시간으로 모니터링을 한다. 소수점은 %.N 값으로
    }
}
