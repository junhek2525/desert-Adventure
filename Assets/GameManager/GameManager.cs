using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager�� �̱��� �ν��Ͻ�
    public static GameManager instance;

    // ���� ���³� ���� ���� �����͸� ���⿡ ����
    public int moeny = 0;
    public bool isGameOver = false;

    // ������ ����(��: ���� ���� ��, ���� ���� ��)�� �����ϴ� ����
    public enum GameState { Menu, Playing, GameOver }
    public GameState currentState = GameState.Menu;

    void Awake()
    {
        // �̱��� ������ �����Ͽ� �ν��Ͻ��� �ϳ��� �����ϵ��� ����
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // �� ��ȯ �ÿ��� �ı����� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject);  // �̹� �����ϴ� �ν��Ͻ��� ������ ���� ������ ��ü�� �ı�
        }
    }

    void Start()
    {
        // ���� ���� ���� �ʱ� ����
        
        isGameOver = false;
        currentState = GameState.Playing;
    }

    // ���� ���� ���� �Լ� ����
    public void StartGame()
    {
        currentState = GameState.Playing;
        
        isGameOver = false;
    }

    public void EndGame()
    {
        currentState = GameState.GameOver;
        isGameOver = true;
        // ���� ���� �� �ʿ��� ó�� �߰�
    }

    // ���� �߰� �Լ�
    public void moenyon(int moenys)
    {
        if (currentState == GameState.Playing)
        {
            moeny += moenys;
        }
    }

    // ���� ���� Ȯ�� �Լ� (���� �������� Ȯ��)
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
