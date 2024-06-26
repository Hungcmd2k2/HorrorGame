using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_3_Chair : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lamp;
    public AudioSource audioghost;
    public BoxCollider box;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Chair_animation.beginrun = true;
           audioghost.Play();
           box.enabled = false;
            
        }
    }
    
}
