using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    public LineRenderer line;
    public Transform hooks;
    Vector2 mousedir;

    public bool isHooks;
    public bool islineMax  ;
    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 2;
        line.endWidth = line.startWidth = 0.05f;
        line.SetPosition(0,transform.position);
        line.SetPosition(1,hooks.position);
        line.useWorldSpace = true;
    } 

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hooks.position);
         
        if(Input.GetKeyDown(KeyCode.E) && !isHooks)
        {
            hooks.position = transform.position;
            mousedir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            isHooks = true;
            islineMax = false;
            hooks.gameObject.SetActive(true);
        }

        if(isHooks && !islineMax)
        {
            hooks.Translate(mousedir.normalized*Time.deltaTime *15);
        

            if(Vector2.Distance(transform.position,hooks.position) > 5)
            {
                islineMax = true ;
            }
        }else if(isHooks && islineMax)
        {
            hooks.position = Vector2.MoveTowards(hooks.position, transform.position, Time.deltaTime * 15);
            if(Vector2.Distance(transform.position, hooks.position) < 0.1f)
            {
                isHooks = false ;
            islineMax = false ; 
            hooks.gameObject.SetActive(false);
            }
            
        }
        
    }
}
