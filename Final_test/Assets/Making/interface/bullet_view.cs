using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_view : MonoBehaviour
{
    public int num;

    public Sprite sprite1;
    public Sprite sprite2;
    SpriteRenderer spriteRenderer;

    int count = 0;
    int load = 0;
    float x;

    public void view()
    {
        int bullet = FindObjectOfType<bullet_manager>().get_bullet();

        if (bullet >= num)
        {
            this.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            this.GetComponent<Image>().sprite = sprite2;
        }
    }
    public void view2()
    {
       this.GetComponent<Image>().sprite = sprite1;
    }

    public void reload()
    {
        if (load == 0)
            load = 1;
    }

    private void Start()
    {
        this.GetComponent<Image>().sprite = sprite1;

        x = transform.position.x;
    }

    private void Update()
    {
        if(load == 1)
        {
            if (count == 0)
            {
                if (transform.position.x + 400 > x)
                    transform.Translate(-1000 * Time.deltaTime, 0, 0);
                else
                {
                    count = 1;
                    view2();
                }
            }

            if (count == 1)
            {
                if (transform.position.x <= x)
                    transform.Translate(1000 * Time.deltaTime, 0, 0);
                else
                {
                    transform.Translate(x - transform.position.x, 0, 0);
                    count = 0;
                    load = 0;
                    FindObjectOfType<bullet_manager>().full_bullet();
                    view();
                }
            }
        }
    }
}
