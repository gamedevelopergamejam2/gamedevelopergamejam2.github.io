using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Max : MonoBehaviour
{
    public float timeStart;
    public float timeStart2;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        timeStart = PlayerPrefs.GetFloat("moghtun");
        timeStart2 = PlayerPrefs.GetFloat("fie");
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStart> timeStart2)
        {
            timeStart2 = timeStart;
           
            PlayerPrefs.SetFloat("fie", timeStart2);
        }
        text.text = timeStart2.ToString("F2");
    }
}
