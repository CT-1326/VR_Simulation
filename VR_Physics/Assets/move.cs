using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float sp = 2f;
    //private Transform tr;


    // Use this for initialization
    void Start()
    {
        //tr = Camera.main.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.localScale = new Vector3(0.3f, 1f, 0.3f);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * sp * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * sp * Time.deltaTime);
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime * 2, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * sp * Time.deltaTime);
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime * 2, 0.0f);
        }

        /*if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            this.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Vector3 vec = tr.TransformDirection(Vector3.forward);

            this.transform.Translate(vec * sp * Time.deltaTime);

        }*/

    }
}
