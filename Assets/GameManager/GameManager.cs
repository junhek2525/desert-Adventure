using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    // GameManager�� �̱��� �ν��Ͻ�
    public static GameManager instance;

    // ���� ���³� ���� ���� �����͸� ���⿡ ����
    public int moeny = 0;
    public List<int> Score;
    public int time = 0;
    public bool isGameOver = false;

    // ������ ����(��: ���� ���� ��, ���� ���� ��)�� �����ϴ� ����
    public enum GameState { Menu, Playing, GameOver }
    public GameState currentState = GameState.Menu;
    public string[] treasure;
    public bool[] itamsave;

    
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
        Score = new List<int>();
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

    public void sale()
    {
        for(int i = 0; i < 8; i++)
        {
            if (treasure[i] == "treasure_copper")
            {
                moeny += 500;
                treasure[i] = "";
            }
            else if(treasure[i] == "treasure_silver")
            {
                moeny += 1000;
                treasure[i] = "";
            }
            else if(treasure[i] == "treasure_gold")
            {
                moeny += 2500;
                treasure[i] = "";
            }
            else if (treasure[i] == "treasure_diamond")
            {
                moeny += 5000;
                treasure[i] = "";
            }
            else
            {
                treasure[i] = "";
            }

        }
    }









}
