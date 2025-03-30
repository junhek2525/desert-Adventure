using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // ESC 키를 눌러서 게임을 멈추거나 다시 시작할 수 있도록 설정
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // 0이면 멈추고, 1이면 다시 시작
    }
}
