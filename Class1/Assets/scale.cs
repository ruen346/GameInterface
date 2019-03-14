using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    int scalestate = 0;
    Vector3 MaxScale;
    Vector3 MinScale;
    GameObject cube;

    // Use this for initialization
    void Start ()
    {
        MaxScale = new Vector3(10.0f, 10.0f, 10.0f);
        MinScale = new Vector3(1.0f, 1.0f, 1.0f);
        cube = GameObject.Find("Cube");
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(scalestate == 1)
        {
            if (cube.transform.localScale.x >= MaxScale.x)
                scalestate = 0;
            cube.transform.localScale += (new Vector3(1.0f, 1.0f, 1.0f) * Time.deltaTime);
        }
        else if(scalestate == 2)
        {
            if (cube.transform.localScale.x <= MinScale.x)
                scalestate = 0;
            cube.transform.localScale -= (new Vector3(1.0f, 1.0f, 1.0f) * Time.deltaTime);
        }
	}

    public void ScaleOn()
    {
        scalestate = 1;
    }
    public void ScaleOff()
    {
        scalestate = 2;
    }
}
