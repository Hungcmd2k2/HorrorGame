using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;
    public Canvas textpickupflash;
    public AudioSource flashlightsource;
    public Canvas huongdan;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void PickFlashlight()
    {
        flashlightsource.Play();
        huongdan.gameObject.SetActive(true);

        Player_HandleFlash.flashlight = true;
        StartCoroutine(DelayedFunction(1f));
        IEnumerator DelayedFunction(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
           flashlight.gameObject.SetActive(false);
        }
    }
    public void ShowText()
    {
        textpickupflash.gameObject.SetActive(true);
    }
}
