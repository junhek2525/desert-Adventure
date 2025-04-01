using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ceneChanger : MonoBehaviour
{
    public string Scene = "";


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            scenechage();
        }
    }
    void scenechage()
    {
        SceneManager.LoadScene(Scene);
    }
    
}
