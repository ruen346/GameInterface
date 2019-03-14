using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotate : MonoBehaviour
{
    int state = 0;
    float rotate_speed = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(state == 1)
            this.transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime);
	}

    public void ChangeState()
    {
        if (state == 0)
            state = 1;
        else
            state = 0;
    }
}
