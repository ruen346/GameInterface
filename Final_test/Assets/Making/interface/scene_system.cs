using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_system : MonoBehaviour
{
    int a = 60;
    int u = 0;
    public void start_game()
    {
        GetComponent<AudioSource>().Play();
        u = 1; 
    }

    public void end_game()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.OpenURL("http://google.com");
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (u == 1)
            a--;
        if(a == 0)
            SceneManager.LoadScene("Game_scene"); 
    }
}
