using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_manager : MonoBehaviour
{
    static int max_bullet = 5;
    static int bullet = 5;

    public int get_bullet()
    {
        return bullet;
    }

    public void reduce_bullet()
    {
        if (bullet >= 1)
            bullet--;
    }

    public void full_bullet()
    {
        bullet = max_bullet;
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
