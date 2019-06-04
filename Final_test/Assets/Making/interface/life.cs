using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    SpriteRenderer spriteRenderer;

    public void view(int a)
    {
        switch(a)
        {
            case 4:
                this.GetComponent<Image>().sprite = sprite1;
                break;
            case 3:
                this.GetComponent<Image>().sprite = sprite2;
                break;
            case 2:
                this.GetComponent<Image>().sprite = sprite3;
                break;
            case 1:
                this.GetComponent<Image>().sprite = sprite4;
                break;
            case 0:
                this.GetComponent<Image>().sprite = sprite5;
                break;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
