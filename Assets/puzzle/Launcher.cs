using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float cooltime = 3f;
    float curtime;

    public GameObject objectToSpawn;  // 소환할 오브젝트를 연결할 변수
    public Transform spawnPoint;      // 소환될 위치 (Transform을 통해 지정)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
        
    //}
    public void shot()
    {
        if(curtime <=0f)
        {
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            curtime = cooltime;
        }
        else
        {
            curtime -= Time.deltaTime;
        }
        

    }
}
