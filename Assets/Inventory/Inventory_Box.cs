using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using UnityEngine.UIElements;


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
    public int BoxNumber;

    public enum Item
    {
        None,
        apple,
        Oxygen_cylinders,




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


        

    }

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


//if (Inventory.Inventory_nut.Count != 0)
//{
//    if (Inventory.Inventory_nut.Count != BoxNumber && Inventory.Inventory_nut[BoxNumber] != " ")
//    {
//        Inventory_Boxs.GetComponent<Image>().sprite = sprites[0];
//        Items = Item.None;
//    }
//    if (Inventory.Inventory_nut[BoxNumber] == " ")
//    {
//        Inventory_Boxs.GetComponent<Image>().sprite = sprites[0];
//        Items = Item.None;
//    }
//    if (Inventory.Inventory_nut[BoxNumber] == "apple")
//    {
//        Inventory_Boxs.GetComponent<Image>().sprite = sprites[1];
//        Items = Item.apple;
//    }
//    if (Inventory.Inventory_nut[BoxNumber] == "Oxygen_cylinders")
//    {
//        Inventory_Boxs.GetComponent<Image>().sprite = sprites[2];
//        Items = Item.apple;
//    }
//}
//else
//{
//    Inventory_Boxs.GetComponent<Image>().sprite = sprites[0];
//    Items = Item.None;
//}
