using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItem : MonoBehaviour
{
    public Canvas item;
   
    public AudioSource pickupQR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            
            Hideitem();
        }  
    }
    public void Showitem()
    {
        pickupQR.Play();
        item.gameObject.SetActive(true);
       
    }
    public void Hideitem()
    {
        item.gameObject.SetActive(false);
        
    }
}
