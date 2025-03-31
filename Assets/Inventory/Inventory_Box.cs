using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory_Box : MonoBehaviour
{
    // Start is called before the first frame update

    
    //public MonoBehaviour monoBehaviour;
    public Inventory Inventory;
    public stat stat;
    public Inventory_Image inventory_Image;

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
        if (Inventory.Inventory_nut[BoxNumber] == "")
        {
            inventory_Image.number = 0;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "apple")
        {
            inventory_Image.number = 1;
        }
        if (Inventory.Inventory_nut[BoxNumber] == "Oxygen_cylinders")
        {
            inventory_Image.number = 2;
        }
    }

    public void OnButtonClikck()
    {
        switch(Items)
        { 
            case Item.apple:
            Inventory.Inventory_nut[BoxNumber] = "";
                break;
                case Item.Oxygen_cylinders:
                Inventory.Inventory_nut[BoxNumber] = "";
                break;
            default:
                break;
        }
        
    }    
}
