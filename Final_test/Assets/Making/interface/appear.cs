using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        color.a = 0;
        spr.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        color.a += 0.02f;
        spr.color = color;
    }
}
