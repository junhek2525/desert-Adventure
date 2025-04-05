using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using UnityEngine.UIElements;





// 인벤토리 부분 여기에 버튼을 이용해 아이템을 사용할수있고 박스 번째로 지정해 구별가능하게 만듬
// 사용법: 이미지지정,스탯코드 연결, 인벤토리 몇번째인지 박스넘버에 지정(0번째부터) 스프라이트에 아이템 이미지 맞게 지정

public class Inventory_Box : MonoBehaviour
{
    // Start is called before the first frame update


    //public MonoBehaviour monoBehaviour;
    public Image image;
    public Button Inventory_Boxs;
    public Inventory Inventory;
    public stat stat;
    //public Inventory_Image inventory_Image;

    public Sprite[] sprites;
    public int BoxNumber;  //inventory_nut[BoxNumber]

    public enum Item
    {
        None,
        apple,
        Oxygen_cylinders,
        map,
        speeder_small,
        speeder_big,
        Dumple,
        treasure_copper,
        treasure_silver,
        treasure_gold,
        treasure_diamond


    }
    public Item Items;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Inventory.Inventory_nut[BoxNumber] != null)
        //{

        //}
        //else
        //{

        //}

        // 인벤토리 박스숫자에 있는 아이템마다 이미지를 넣는 코드
        if (Inventory.Inventory_nut[BoxNumber] == "")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[0];
            Items = Item.None;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "apple")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[1];
            Items = Item.apple;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "Oxygen_cylinders")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[2];
            Items = Item.Oxygen_cylinders;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "treasure_copper")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[7];
            Items = Item.treasure_copper;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "treasure_silver")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[8];
            Items = Item.treasure_silver;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "treasure_gold")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[9];
            Items = Item.treasure_gold;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "treasure_diamond")
        {
            Inventory_Boxs.GetComponent<Image>().sprite = sprites[10];
            Items = Item.treasure_diamond;
        }




    }


    //클릭하면 아이템을 사용하고 인벤토리 박스숫자에 사라짐
    public void OnButtonClikck()
    {
        switch(Items)
        {
            case Item.None:
                break;
            case Item.apple:
                Inventory.Inventory_nut[BoxNumber] = "";
                //Inventory.Inventory_nut.Remove(" ");
                stat.Health += 25;
                break;
                case Item.Oxygen_cylinders:
                Inventory.Inventory_nut[BoxNumber] = "";
                stat.oxygen += 25;
                break;
            default:
                break;
        }
        
    }    
}


