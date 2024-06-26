using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ghost_2;
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

            audioghost.Play();
            StartCoroutine(DelayedFunction(1f));
            IEnumerator DelayedFunction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);
                ghost_2.gameObject.SetActive(false);
                box.enabled = false;
            }
        }
    }
}
