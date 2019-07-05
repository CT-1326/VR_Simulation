using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{

    public GameObject txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="player")
        {
            StartCoroutine(work());
        }
    }

    IEnumerator work()
    {
        txt.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        txt.SetActive(false);
    }
}
