using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ceneChanger : MonoBehaviour
{
    public string Scene = "";
    //public GameManager GameManager;
    public Inventory Inventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Inventory inventory = FindObjectOfType<Inventory>();
        
        if (inventory != null)
        {
            inventory.other();
        }
        scenechage();
    }
    void scenechage()
    {
        SceneManager.LoadScene(Scene);
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene(Scene);
    }
    
}
