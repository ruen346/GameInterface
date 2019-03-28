using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csSlider : MonoBehaviour
{
    Text txt;
    Slider slider1;
    Slider slider2;
    int fontSize;

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("teCenter").GetComponent<Text>();
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        fontSize = txt.fontSize;
    }

    public void changeslidervalue()
    {
        float val = slider2.value;
        slider1.value = val;
        txt.fontSize = fontSize * (int)val;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
