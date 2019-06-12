using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class icon_move : MonoBehaviour
{
    static float count = 30;
    static bool check = false;

    public static void move_start()
    {
        check = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0 && check)
        {
            float move = 50 * Time.deltaTime;
            count -= move;

            transform.Translate(-move, move, 0, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ddddd");
    }

    void OnMouseOver()
    {
        Debug.Log("ddddd");
    }   
}
