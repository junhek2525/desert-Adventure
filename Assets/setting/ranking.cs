using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ranking : MonoBehaviour
{

    //public List<int> scores;

    public GameManager manager;
    public Text timeResultText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rank()
    {
        GameManager.instance.Score.Add((int)GameManager.instance.time);
        GameManager.instance.Score.Sort();
        int timeM = (int)GameManager.instance.time /60;
        int timeS = (int)GameManager.instance.time % 60;
        timeResultText.text = "Time :" + timeM.ToString("D2") + ":" + timeS.ToString("D2");
    }
}
