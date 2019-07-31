using UnityEngine;
using System.Collections;

public class bulletTower : MonoBehaviour
{
    Vector3 gravityPoint = new Vector3(0, 0, 0); // 중력 X,Y,Z 포인트 값
    float rotationsPerMinute = 10;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce((gravityPoint - transform.position).normalized); // 지구 주변을 공전...공전에는 벡터의 정규화를 통해 방향 고정과 크기를 맞춰 나간다
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime); // 현재 오브젝트의 Z 회전 값을 변화
    }

}
