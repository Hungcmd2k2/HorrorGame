using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKeyDoor_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PassDoor_3;
    public GameObject LockDoor;
    public GameObject ghost;
    
    // Tạo một biến để lưu trữ Audio Source
    public AudioSource audioSource;
    private bool audioplay;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KeyLock()
    {

        Door_NoKey_3.keyfound_3 = true;
        Debug.Log("Nhặt được chìa khóa rồi");
        AudioGhost4.audioghost = true;
        PlayAudio();
    }
    public void PlayAudio()
    {
        // Phát âm thanh từ Audio Source
        audioSource.Play();
        ghost.gameObject.SetActive(true);

        StartCoroutine(DelayedFunction(0.5f));
        IEnumerator DelayedFunction(float delayTime)
        {  
            yield return new WaitForSeconds(delayTime);
           

            PassDoor_3.gameObject.SetActive(false);
            LockDoor.gameObject.SetActive(false);
        }

    }
}
