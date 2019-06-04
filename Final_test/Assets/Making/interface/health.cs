using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider slider;

    public void check(float a)
    {
        slider.value = a;
    }
}
