using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject main_tank;

    public float offsetX = 50f;
    public float offsetY = 32f;
    public float offsetZ = 52f;

    Vector3 camera_position;

    void Update()
    {
        camera_position.x = main_tank.transform.position.x + offsetX;
        camera_position.y = main_tank.transform.position.y + offsetY;
        camera_position.z = main_tank.transform.position.z + offsetZ;

        if (camera_position.x < -19)
            camera_position.x = -19;

        if (camera_position.x > 133)
            camera_position.x = 133;

        if (camera_position.z < -33)
            camera_position.z = -33;

        if (camera_position.z > 130)
            camera_position.z = 130;

        transform.position = camera_position;
    }
}
