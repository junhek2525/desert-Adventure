using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // ESC Ű�� ������ ������ ���߰ų� �ٽ� ������ �� �ֵ��� ����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // 0�̸� ���߰�, 1�̸� �ٽ� ����
    }
}
