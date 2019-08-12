using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    Text txt;
    static int Level = 1; // Quiz level
    static int sum = 0; // Quiz score
    float time = 5f; // Timer

    public void correct() 
    {
        if (Level == 1 || Level == 3 || Level == 5) // if correct
        {
            sum++;
            Level++;
        }
        else // or not
            Level++;

        StartCoroutine(show_text());
    }
    public void wrong()
    {
        if(Level == 2 || Level == 4)
        {
            sum++;
            Level++;
        }
        else
            Level++;

        StartCoroutine(show_text()); // show text related quiz
    }

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>();
        txt.text = "text\ntext1\ntext done";
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator show_text()
    {
        switch (Level) 
        {
            case 2:
                txt.text = "text\ntext2\ntext done";
                break;
            case 3:
                txt.text = "text\ntext3\ntext done";
                break;
            case 4:
                txt.text = "text\ntext4\ntext done";
                break;
            case 5:
                txt.text = "text\ntext5\ntext done";
                break;
            default:
                txt.text = "Score : " + sum + "\n5sec will move";
                StartCoroutine(ch_time());
                break;
        }
        yield return null;
    }

    IEnumerator ch_time()
    {
        while(true)
        {
            time -= Time.deltaTime;
            if (time < 0)
                SceneManager.LoadScene("Newtons");
            yield return null;

        }     
    }
}
