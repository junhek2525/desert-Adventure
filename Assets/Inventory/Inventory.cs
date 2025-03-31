using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("number")]
    //[SerializeField] public string[] Inventory_nut;
    [SerializeField] public int Inventory_Maxnut = 4;
    [SerializeField] public int weight =0;
    [SerializeField] public List<string> Inventory_nut = new List<string> {  };
    [SerializeField] public int Maxweight = 1000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            //Inventory_nut.RemoveAt(Inventory_nut.Count - 1);
        
    }
    public void item(string item)
    {
        for (int i=0; i < Inventory_Maxnut; i++)
        {
            //if(Inventory_nut[i] >= )
            //{

            //}
            if(Inventory_nut[i] == "")
            {
                
                Inventory_nut.Add(item);
                break;
            }
        }
    }
}
