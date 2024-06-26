using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controler : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("open");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("close");
        }
    }
}
