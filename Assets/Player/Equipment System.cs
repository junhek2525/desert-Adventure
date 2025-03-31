using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    public string knife = "knife";
    public string flashlight = "flashlight";
    public string Oxygen_cylinders = "Oxygen_cylinders";
    public string bag = "bag";
    public string rope = "rpoe";
    public string Expedition_Shirt = "";
    public string Explorer_s_Hat = "";
    public string Explorer_Boots = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void upgrade(string equipment)
    {
        Debug.Log(equipment);
        if (equipment == "knife+1")
        {
            knife = "+1";
        }
        if (equipment == "knife+2")
        {
            knife = "+2";
        }
        if(equipment == "Oxygen_cylinders+1")
        {
            Oxygen_cylinders = "+1";
        }
        if (equipment == "Oxygen_cylinders+2")
        {
            Oxygen_cylinders = "+2";
        }
        if (equipment == "Oxygen_cylinders+3")
        {
            Oxygen_cylinders = "+3";
        }
        if (equipment == "flashlight+1")
        {
            flashlight = "+1";
        }
        if (equipment == "flashlight+1")
        {
            flashlight = "+1";
        }
        if (equipment == "bag+1")
        {
            bag = "+1";
        }
        if (equipment == "bag+2")
        {
            bag = "+2";
        }
        if (equipment == "rope+1")
        {
            rope = "+1";
        }

    }
}
