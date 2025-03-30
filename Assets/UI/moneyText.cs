using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyText : MonoBehaviour
{

    public Text moneyTexts;

    //public stat stat;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyTexts.text = "µ·: " + manager.moeny + " ¿ø";
    }
}
