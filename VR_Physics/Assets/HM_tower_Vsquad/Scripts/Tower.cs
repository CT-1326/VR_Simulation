using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
    public Transform shootElement; // 대포알 발사 시작점
    public GameObject bullet; // 대포알 모델

    float speed = .2f; // 대포알 스피드 값
    double fireTimer = 0.0; // 대포알 하나씩 끊어서 발사하기 위한 발사 시간
    double fireTimerLength = .25; // 발사 시간 최대 값

    bool isShoot = false; // 대포 발사 여부

    void Start()
    {

    }

    void Update()
    {
        if (isShoot) // 대포가 발사 되었을 때
        {
            fireTimer += Time.deltaTime; // 1초씩 카운트해서 최대 값 만큼 도달시킨다
            if (fireTimer >= fireTimerLength)
            {
                fireTimer = 0.0;
                isShoot = false;
            }
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad) || Input.GetKey(KeyCode.R)) // 특정 키가 눌렸을 때
        {
            if (!isShoot) // 대포알 발사 전이면
            {
                float force = GameObject.Find("Slider").GetComponent<UnityEngine.UI.Slider>().value; // ui의 슬라이더 값을 실수로 받는다
                Debug.Log("Fire! " + force);
                isShoot = true; // 대포알이 발사 되었음을 알림
                // Instantiate new satellite
                GameObject bulletClone = (GameObject)Instantiate(bullet, shootElement.position,shootElement.rotation); // 복제본을 만들어 하나하나 독립적인 객체 대포알을 만든다
                // Set velocty on satellite
                bulletClone.GetComponent<Rigidbody>().velocity = transform.forward * (speed * force); // 대포알이 앞으로 나가는데 기존 스피드 값과 슬라이더 값의 곱한 것 만큼 나갈 수 있게 해준다
            }
        }

    }
}
