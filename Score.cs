using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float timeStart;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        timeStart = PlayerPrefs.GetFloat("moghtun");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = timeStart.ToString("F2");
    }
}
