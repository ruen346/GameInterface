using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{

    GameObject obj;
    Text txt;
    // Use this for initialization
    void Start()
    {
        obj = GameObject.Find("teCenter");
        txt = obj.GetComponent<Text>();
    }

    public void changneText()
    {
        txt.text = "홍길동";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
