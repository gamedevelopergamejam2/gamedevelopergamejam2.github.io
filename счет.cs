using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class счет : MonoBehaviour
{
    public float timeStart;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        text.text = timeStart.ToString("F2");
        PlayerPrefs.SetFloat("moghtun", timeStart);
    }
}
