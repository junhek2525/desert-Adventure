using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenUI : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update

    public void Maxoxygen(float oxygen)
    {
        slider.maxValue = oxygen;
        slider.value = oxygen;
    }


    public void Setoxygen(float oxygen)
    {
        slider.value = oxygen;
    }
}
