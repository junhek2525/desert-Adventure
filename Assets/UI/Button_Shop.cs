using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Button_Shop : MonoBehaviour
{

    public UnityEngine.UI.Button button_shop;
    public bool store = false;
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        // isTrue ���� ������Ŵ
        store = true;

        // ����� �� Ȯ��
        //Debug.Log("isTrue: " + isTrue);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("isTrue: " + store);
    }
    //void on()
    //{
    //    Debug.Log("����");
    //    store = true;
    //}
}
