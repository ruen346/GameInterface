using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enemy()
    {
        this.GetComponent<Image>().sprite = sprite1;
    }
    public void character()
    {
        this.GetComponent<Image>().sprite = sprite2;
    }
}
