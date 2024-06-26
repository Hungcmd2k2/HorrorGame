using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioEnding : MonoBehaviour
{
    public AudioClip musicClip; // AudioClip chứa nhạc bạn muốn phát
    private AudioSource audioSource; // AudioSource để phát nhạc

    void Start()
    {
        // Lấy reference đến AudioSource
        audioSource = GetComponent<AudioSource>();

        // Thiết lập musicClip cho AudioSource
        audioSource.clip = musicClip;

        // Bắt đầu phát nhạc
        audioSource.Play();
    }

    void Update()
    {
        // Kiểm tra xem nhạc đã kết thúc chưa
        if (!audioSource.isPlaying)
        {
            // Nếu nhạc đã kết thúc, bắt đầu phát lại từ đầu
            audioSource.Play();
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
    }
}
