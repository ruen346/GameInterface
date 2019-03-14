using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float rotate_speed = 10.0f;
    GameObject cube;
    int rotate_state = 0;

	// Use this for initialization
	void Start ()
    {
        cube = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if(rotate_state == 1)
            //cube.transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime);
	}

    public void RotateOn()
    {
        //rotate_state = 1;
        cube.SendMessage("ChangeState", SendMessageOptions.DontRequireReceiver);
    }
    public void RotateOff()
    {
        //rotate_state = 0;
    }
}
