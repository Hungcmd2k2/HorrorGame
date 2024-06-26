using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Canvas info;
    public Canvas Continue;
    public Slider Loading_slider;
    public float loadingTime = 0.05f;


    public void HandleButtonClick()
    {
        // Xử lý sự kiện khi Button được nhấn
        Debug.Log("Button clicked!");
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        Loading_slider.gameObject.SetActive(true);
        StartCoroutine(Loading());


    }
    IEnumerator Loading()
    {
        for (int i = 0; i <= 100; i++)
        {
            // Cập nhật giá trị của Slider
            Loading_slider.value = i;

            // Chờ một khoảng thời gian delayTime giữa các bước loading
            yield return new WaitForSeconds(loadingTime);
        }

        Debug.Log("Load game thành công?");
        SceneManager.LoadScene("Level_Design");
    }
    public void ShowInfomation()
    {
       info.gameObject.SetActive(true);
    }
    public void HideInfomation()
    {
        info.gameObject.SetActive(false);
    }
    public void ShowContine()
    {
        Continue.gameObject.SetActive(true);
    }
    public void HideContine()
    {
        Continue.gameObject.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Thoat Gam roi nhe");
    }
}
