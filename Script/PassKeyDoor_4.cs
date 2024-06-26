using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKeyDoor_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PassDoor_4;
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

        Door_NoKey_4.keyfound_4 = true;
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
            PassDoor_4.gameObject.SetActive(false);
            LockDoor.gameObject.SetActive(false);
        }

    }
}
