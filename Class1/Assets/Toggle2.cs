using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2 : MonoBehaviour
{
    Text txt;
    Toggle toggle1;
    Toggle toggle2;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("teCenter").GetComponent<Text>();
        toggle1 = GameObject.Find("Toggle1").GetComponent<Toggle>();
        toggle2 = GameObject.Find("Toggle2").GetComponent<Toggle>();
        toggle1.isOn = true;
        toggle2.isOn = false;
        txt.text = "Toggle1";
    }

    public void ChangeText()
    {
        if (toggle1.isOn)
        {
            toggle2.isOn = false;
            txt.text = "Toggle1";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
