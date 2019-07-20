using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class show_move : MonoBehaviour
{
    public GameObject go;
    TextMeshProUGUI txt;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Z : " + go.transform.localPosition.z.ToString("N2");
    }
}
