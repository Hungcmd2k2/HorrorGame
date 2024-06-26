using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuidioManager : MonoBehaviour
{
    public AudioClip[] audioClips; // Danh sách các AudioClip
    private AudioSource audioSource; // AudioSource để phát các AudioClip

    void Start()
    {
        // Lấy reference đến AudioSource
        audioSource = GetComponent<AudioSource>();

        // Kiểm tra xem danh sách AudioClip có tồn tại hay không
        if (audioClips.Length > 0)
        {
            // Bắt đầu phát AudioClip ngẫu nhiên từ danh sách
            PlayRandomClip();
        }
    }

    void Update()
    {
        // Kiểm tra xem có phát hết danh sách AudioClip chưa
        if (!audioSource.isPlaying)
        {
            // Phát lại AudioClip ngẫu nhiên khi đã phát hết
            PlayRandomClip();
        }
    }

    void PlayRandomClip()
    {
        // Chọn ngẫu nhiên một chỉ số từ danh sách AudioClip
        int randomIndex = Random.Range(0, audioClips.Length);

        // Lấy AudioClip từ danh sách sử dụng chỉ số ngẫu nhiên
        AudioClip randomClip = audioClips[randomIndex];

        // Phát AudioClip đã chọn
        audioSource.clip = randomClip;
        audioSource.Play();
    }
}
