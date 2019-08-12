using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
    public Transform shootElement; // Bullet start point
    public GameObject bullet; // Bullet

    float speed = .3f; // Bullet speed
    double fireTimer = 0.0; // Bullet timer
    double fireTimerLength = .25; // Bullet timer max value

    bool isShoot = false; // Cannon fire on/off

    void Start()
    {

    }

    void Update()
    {
        if (isShoot) // when cannon fire
        {
            fireTimer += Time.deltaTime;
            if (fireTimer >= fireTimerLength)
            {
                fireTimer = 0.0;
                isShoot = false;
            }
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad) || Input.GetKey(KeyCode.R)) 
        {
            if (!isShoot) // if cannon is not fire yet
            {
                float force = GameObject.Find("Slider").GetComponent<UnityEngine.UI.Slider>().value; // get ui silder value
                Debug.Log("Fire! " + force);
                isShoot = true;
                // Instantiate new satellite
                GameObject bulletClone = (GameObject)Instantiate(bullet, shootElement.position,shootElement.rotation); // make clone bullet
                // Set velocty on satellite
                bulletClone.GetComponent<Rigidbody>().velocity = transform.forward * (speed * force); // go forward
            }
        }

    }
}
