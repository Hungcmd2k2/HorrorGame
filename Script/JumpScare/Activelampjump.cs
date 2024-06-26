using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activelampjump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Turn_on_off.satelamp = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Turn_on_off.satelamp = false;
           
        }
    }
   
}
