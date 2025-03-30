using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpUl : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    
    public void MaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    
    public void SetHealth(float Health)
    {
        slider.value = Health;
    }
}
