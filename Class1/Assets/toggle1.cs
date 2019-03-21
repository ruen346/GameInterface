using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle1 : MonoBehaviour {
    GameObject tgobj;
    GameObject txobj;
    Text txt;
    Toggle tgchange;
	// Use this for initialization
	void Start () {
        tgobj = GameObject.Find("tgText");
        txobj = GameObject.Find("teCenter");
        tgchange = tgobj.GetComponent<Toggle>();
        txt = txobj.GetComponent<Text>();
	}

    public void changeText()
    {
        if(tgchange.isOn)
        {
            txt.text = "안녕";
        }
        else
        {
            txt.text = "바바";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
