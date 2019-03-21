using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name2 : MonoBehaviour {
    GameObject obj;
    Text txt;
	// Use this for initialization
	void Start () {
        obj = GameObject.Find("teCenter");
        txt = obj.GetComponent<Text>();
	}

    public void changeText()
    {
        txt.text = "아아아아아ㅏ아아아아아아아아아아아ㅏ아아";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
