using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayEr : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetTrigger("Play");
        StartCoroutine(DelayCoroutine(12f));
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator DelayCoroutine(float delayTime)
    {
        // Chờ một khoảng thời gian delayTime
        yield return new WaitForSeconds(delayTime);

        // Sau khi chờ xong, thực hiện các hành động tiếp theo ở đây
        Debug.Log("Chay xong aim va tat anim");
        Animator.enabled = false;
    }
}
 
   

    