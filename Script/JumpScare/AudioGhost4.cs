using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioGhost4 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool audioghost;
    public AudioSource audiosource;
    public GameObject ghost;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (audioghost)
        {
            audiosource.Play(); 
            audioghost = false;
            StartCoroutine(DelayedFunction(1.5f));
           
        }
    }
    IEnumerator DelayedFunction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ghost.gameObject.SetActive(false);
        
    }
}
