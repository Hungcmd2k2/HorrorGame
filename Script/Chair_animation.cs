using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair_animation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public static bool beginrun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (beginrun)
        {
            CallAnim();
        }
    }
    public void CallAnim()
    {
        anim.SetTrigger("Run");
        beginrun = false;
    }
}
