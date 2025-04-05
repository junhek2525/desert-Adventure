using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //인벤토리 그 자체 여기에 인벤토리가 있고 관리하는 코드
    

    [Header("number")]
    //[SerializeField] public string[] Inventory_nut;
    [SerializeField] public int Inventory_Maxnut = 4; //최대 인벤토리 수량
    [SerializeField] public int weight =0; //무게
    [SerializeField] public List<string> Inventory_nut; //!인벤토리! 처음에 4개를 만듬
    [SerializeField] public int Maxweight = 1000; //최대무게


    public GameManager GameManager ; //게임 매니저
    
    // Start is called before the first frame update
    void Start()
    {
        //Inventory_nut = new List<string>();
       
    }

    // Update is called once per frame
    void Update()
    {
        // 현재 인벤토리 수량보다 최대 인벤토리 수량이 많으면 현재 인벤토리 수량을 추가
        if(Inventory_Maxnut> Inventory_nut.Count)
        {
            Inventory_nut.Add("");
        }

        //Inventory_nut.RemoveAt(Inventory_nut.Count - 1);

    }
    //아이템을 처먹으면 현재 인벤토리를 전체 점검하고 빈인벤토리가 있으면 거기에 삽입
    public void item(string item) //아이템 이름
    {
        for (int i = 0; i < Inventory_Maxnut; i++) // 0번째시작; 최대인벤토리 수량보다 많아질때까지 반복; ++
        {
            if (Inventory_nut[i] == "") //점검하는 i번째에 인벤토리 내용이 비어있으면
            {
                Inventory_nut[i] = item; //넣기
                break; //반복끝내기
            }

        }
    }


    public void other()
    {
        
            for (int i = 0; i < Inventory_Maxnut; i++)
        {
            if (Inventory_nut[i] != "")
            {
                GameManager.instance.treasure[i] = Inventory_nut[i];
                Inventory_nut[i] = "";
                
            }

        }

    }
        //Inventory_nut.Add(item);
}


