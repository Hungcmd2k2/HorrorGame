using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCredit : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetTrigger("PLAY");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
