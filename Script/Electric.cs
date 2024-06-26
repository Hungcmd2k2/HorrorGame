using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AllLamp;
    public Canvas textlamp;
    public Animator animator;
    public bool lampState;
    private void Start()
    {
        lampState = false;
    }
    public void showText()
    {
        textlamp.gameObject.SetActive(true);
    }
   public void TurnLamp()
    {
        if (lampState==false)
        {
            animator.SetTrigger("TurnOn");
            StartCoroutine(DelayedFunction(2f));
            IEnumerator DelayedFunction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);
                AllLamp.gameObject.SetActive(true);
                lampState = true;
            }
            
            
        }
        else
        {
            animator.SetTrigger("TurnOff");
            StartCoroutine(DelayedFunction(2f));
            IEnumerator DelayedFunction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);
                AllLamp.gameObject.SetActive(false);
                lampState = false;
            }
        }
    }
}
