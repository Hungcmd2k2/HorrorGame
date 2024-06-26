using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKeyDoor_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PassDoor_2;
    public GameObject LockDoor;
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

        Door_NoKey_2.keyfound_2 = true;
        Debug.Log("Nhặt được chìa khóa rồi");
        PlayAudio();
    }
    public void PlayAudio()
    {
        // Phát âm thanh từ Audio Source
        audioSource.Play();
        StartCoroutine(DelayedFunction(1f));
        IEnumerator DelayedFunction(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
            PassDoor_2.gameObject.SetActive(false);
            LockDoor.gameObject.SetActive(false);
        }

    }
}
