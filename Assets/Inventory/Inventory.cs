using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //�κ��丮 �� ��ü ���⿡ �κ��丮�� �ְ� �����ϴ� �ڵ�
    

    [Header("number")]
    //[SerializeField] public string[] Inventory_nut;
    [SerializeField] public int Inventory_Maxnut = 4; //�ִ� �κ��丮 ����
    [SerializeField] public int weight =0; //����
    [SerializeField] public List<string> Inventory_nut; //!�κ��丮! ó���� 4���� ����
    [SerializeField] public int Maxweight = 1000; //�ִ빫��


    public GameManager GameManager ; //���� �Ŵ���
    
    // Start is called before the first frame update
    void Start()
    {
        //Inventory_nut = new List<string>();
       
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �κ��丮 �������� �ִ� �κ��丮 ������ ������ ���� �κ��丮 ������ �߰�
        if(Inventory_Maxnut> Inventory_nut.Count)
        {
            Inventory_nut.Add("");
        }

        //Inventory_nut.RemoveAt(Inventory_nut.Count - 1);

    }
    //�������� ó������ ���� �κ��丮�� ��ü �����ϰ� ���κ��丮�� ������ �ű⿡ ����
    public void item(string item) //������ �̸�
    {
        for (int i = 0; i < Inventory_Maxnut; i++) // 0��°����; �ִ��κ��丮 �������� ������������ �ݺ�; ++
        {
            if (Inventory_nut[i] == "") //�����ϴ� i��°�� �κ��丮 ������ ���������
            {
                Inventory_nut[i] = item; //�ֱ�
                break; //�ݺ�������
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


