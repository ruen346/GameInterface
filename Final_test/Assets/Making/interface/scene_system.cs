using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_system : MonoBehaviour
{
    public void start_game()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Game_scene");
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
