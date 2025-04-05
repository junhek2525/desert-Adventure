using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using

public class Inventory_bag2 : MonoBehaviour
{

    // 최대 인벤토리 수량마다 버튼이 보일지 말지 정하는 코드

    public GameObject bag;
    bool E = false;

    //나머지 연결할 버튼들
    public GameObject setObject;
    public GameObject setObject2;
    public GameObject setObject3;
    public GameObject setObject4;

    public Inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        bag.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) //가방 열기/닫기
        {
               E = !E;
               bag.SetActive(E);
        }
        // 씌바 뭔지 알겠죠?
        if(Inventory.Inventory_nut.Count >= 5)
        {
            setObject.SetActive(true);
        }
        else
        {
            setObject.SetActive(false);
        }
        if (Inventory.Inventory_nut.Count >= 6)
        {
            setObject2.SetActive(true);
        }
        else
        {
            setObject2.SetActive(false);
        }
        if (Inventory.Inventory_nut.Count >= 7)
        {
            setObject3.SetActive(true);
        }
        else
        {
            setObject3.SetActive(false);
        }
        if (Inventory.Inventory_nut.Count >= 8)
        {
            setObject4.SetActive(true);
        }
        else
        {
            setObject4.SetActive(false);
        }





    }
}
