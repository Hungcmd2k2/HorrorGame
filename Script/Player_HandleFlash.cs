using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HandleFlash : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool flashlight;
    public GameObject flash;
    public AudioSource flashsource;
    public bool flashstate;
   
    void Start()
    {
        flashstate = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            TurnFlash();
        }
    }
    public void TurnFlash()
    {   
       
        if (flashlight)
        {
            if (flashstate==false)
            {
                flashsource.Play();
                flash.gameObject.SetActive(true);
                flashstate = true;
            }
            else
            {
                flashsource.Play();
                flash.gameObject.SetActive(false);
                flashstate = false;
            }
            
        }
        else
        {
            Debug.Log("Chưa có đèn");
        }
    }
}
