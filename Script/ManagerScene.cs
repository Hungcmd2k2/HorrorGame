using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    public static bool isPuzzleSolved = false;

    void Start()
    {
        // Đặt lại giá trị của biến isPuzzleSolved khi bắt đầu một game mới
        isPuzzleSolved = false;

        // Tiếp tục thực hiện các hoạt động khác khi bắt đầu game mới
    }
}
