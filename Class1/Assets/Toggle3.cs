using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle3 : MonoBehaviour
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
    }

    public void ChangeText()
    {
        if (toggle2.isOn)
        {
            toggle1.isOn = false;
            txt.text = "Toggle2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
