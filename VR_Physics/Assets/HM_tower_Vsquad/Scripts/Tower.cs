using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{

    public Transform shootElement;
    public GameObject bullet;

    Vector3 offset = new Vector3(.15f, 0, -.15f);

    float speed = .2f;
    double fireTimer = 0.0;
    double fireTimerLength = .25;

    bool isShoot = false;

    void Start()
    {

    }

    void Update()
    {
        if (isShoot)
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
            // if is not already firing, start firing
            if (!isShoot)
            {
                // Get force value from slider
                float force = GameObject.Find("Slider").GetComponent<UnityEngine.UI.Slider>().value;
                Debug.Log("Fire! " + force);
                isShoot = true;
                // Instantiate new satellite
                GameObject bulletClone = (GameObject)Instantiate(bullet, shootElement.position, transform.rotation);
                // Set velocty on satellite
                bulletClone.GetComponent<Rigidbody>().velocity = transform.forward * (speed * force);
            }
        }

    }
}
