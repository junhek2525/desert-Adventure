using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    private bool isPaused = false;
    [System.Obsolete]
    void Update()
    {
        // ESC Ű�� ������ ������ ���߰ų� �ٽ� ������ �� �ֵ��� ����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        UnityEngine.Assertions.Assert.raiseExceptions = false;

    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // 0�̸� ���߰�, 1�̸� �ٽ� ����
    }
}
