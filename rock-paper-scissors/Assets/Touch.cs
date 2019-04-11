using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public AudioClip voice1;
    public AudioClip voice2;
    Animator animator;
    AudioSource univoice;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        univoice = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Touch", false);
        animator.SetBool("TouchHead", false);
        Ray ray;
        RaycastHit hit;
        GameObject hitobject;
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100))
            {
                hitobject = hit.collider.gameObject;
                if(hitobject.gameObject.tag == "Head")
                {
                    animator.SetBool("TouchHead", true);
                    univoice.clip = voice1;
                    univoice.Play();
                }
                else if(hitobject.gameObject.tag == "Breast")
                {
                    animator.SetBool("Touch", true);
                    univoice.clip = voice2;
                    univoice.Play();
                }
            }
        }
    }
}
