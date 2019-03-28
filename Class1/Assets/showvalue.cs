using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showvalue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void updateLabel(float value)
    {
        Text lb1 = GetComponent<Text>();
        if(lb1 != null)
        {
            lb1.text = Mathf.RoundToInt(value * 10) + "%";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
