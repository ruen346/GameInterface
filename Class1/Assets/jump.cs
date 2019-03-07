using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    float jumpspeed = 5.0f;
    GameObject cube;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {

	}

   public void cubejump()
   {
        cube.GetComponent<Rigidbody>().velocity = Vector3.up * jumpspeed;
   }
}
