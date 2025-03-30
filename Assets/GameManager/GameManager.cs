using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager의 싱글톤 인스턴스
    public static GameManager instance;

    // 게임 상태나 점수 등의 데이터를 여기에 저장
    public int moeny = 0;
    public bool isGameOver = false;

    // 게임의 상태(예: 게임 진행 중, 게임 종료 등)를 관리하는 변수
    public enum GameState { Menu, Playing, GameOver }
    public GameState currentState = GameState.Menu;

    void Awake()
    {
        // 싱글톤 패턴을 적용하여 인스턴스가 하나만 존재하도록 보장
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // 씬 전환 시에도 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject);  // 이미 존재하는 인스턴스가 있으면 새로 생성된 객체는 파괴
        }
    }

    void Start()
    {
        // 게임 시작 시의 초기 상태
        
        isGameOver = false;
        currentState = GameState.Playing;
    }

    // 게임 상태 변경 함수 예시
    public void StartGame()
    {
        currentState = GameState.Playing;
        
        isGameOver = false;
    }

    public void EndGame()
    {
        currentState = GameState.GameOver;
        isGameOver = true;
        // 게임 종료 시 필요한 처리 추가
    }

    // 점수 추가 함수
    public void moenyon(int moenys)
    {
        if (currentState == GameState.Playing)
        {
            moeny += moenys;
        }
    }

    // 게임 상태 확인 함수 (게임 오버인지 확인)
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
