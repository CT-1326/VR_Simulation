using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public Transform shootElement;
	public Transform LookAtObj;
	public int dmg = 10;
	public GameObject bullet;
	public Transform target;
	public float shootDelay;
	bool isShoot;
	void Start () {
	
	}
	
	void Update () {
	if(target)
	{
		LookAtObj.transform.LookAt(target);
		if(!isShoot)
	{
		StartCoroutine(shoot());
	}
	}
	}

	IEnumerator shoot()
	{
		isShoot = true;
		yield return new WaitForSeconds(shootDelay);
		GameObject b = GameObject.Instantiate(bullet,shootElement.position,Quaternion.identity) as GameObject;
		b.GetComponent<bulletTower>().target = target;
		isShoot = false;
	}
}
