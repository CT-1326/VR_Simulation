using UnityEngine;
using System.Collections;

public class bulletTower : MonoBehaviour {

	public float Speed;
	public Transform target;
    public Transform LookAtBul;
    public Tower twr;
    // Use this for initialization

    // Update is called once per frame
    void Update () {
        if (target)
        {
            LookAtBul.transform.LookAt(target);
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * Speed);
        }
	
	}
    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.transform == target)
        {
            Destroy(gameObject);
        }
    }

}
