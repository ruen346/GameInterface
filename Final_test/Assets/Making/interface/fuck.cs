using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fuck : MonoBehaviour
{
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && a == 1)
        {   
            Time.timeScale = 1;
            SceneManager.LoadScene("Start_scene");
        }
    }

    public void move()
    {
        transform.Translate(1920, 0, 0);
        a = 1;
        Time.timeScale = 0;
    }

    public void go()
    {
        if (a == 1)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Start_scene");
        }
    }
}
