using UnityEngine;
using System.Collections;

public class bulletTower : MonoBehaviour
{
    Vector3 gravityPoint = new Vector3(0, 0, 0);
 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce((gravityPoint - transform.position).normalized);
    }

}
