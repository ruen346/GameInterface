using UnityEngine;

public class happy : MonoBehaviour
{
    int end = 0;
    int move = 0;

    // Start is called before the first frame update
    void Start()
    {
        end = 0;
        move = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(end == 1)
        {
            move = 1920;
            end = 0;
        }

        if(move > 0)
        {
            transform.Translate(1920 / 30, 0, 0);
            move -= 1920/30;
        }
    }

    public void get_end(int a)
    {
        end = a;
    }
}
