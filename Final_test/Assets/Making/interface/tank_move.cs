using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_move : MonoBehaviour
{
    bool check = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -550 + 960)
            transform.Translate(300 * Time.deltaTime, -300 * Time.deltaTime, 0, Space.World);
        else
        {
            if (check)
            {
                check = false;
                icon_move.move_start();
            }
        }
    }
}
