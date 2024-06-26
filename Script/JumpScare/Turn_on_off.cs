using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_on_off : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool satelamp;
    public Animator anim;
    public AudioSource audiolamp;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (satelamp)
        {
            anim.SetTrigger("Turn_on_off");
            
            
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playaudio();
        }
    }
    public  void playaudio()
    {
        audiolamp.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audiolamp.Stop();
        }
    }
}
