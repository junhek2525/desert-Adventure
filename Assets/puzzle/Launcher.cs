using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float cooltime = 3f;
    float curtime;

    public GameObject objectToSpawn;  // ��ȯ�� ������Ʈ�� ������ ����
    public Transform spawnPoint;      // ��ȯ�� ��ġ (Transform�� ���� ����)
    public enum Direction { Up, Down, Left, Right }
    public Direction currentDirection;


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
        //if()
        //{

        //}



        //switch (currentDirection)
        //{
        //    case Direction.Up:
        //        transform.rotation = Quaternion.Euler(0, 0, 0); // ����
        //        break;
        //    case Direction.Down:
        //        transform.rotation = Quaternion.Euler(0, 0, 180); // �Ʒ���
        //        break;
        //    case Direction.Left:
        //        transform.rotation = Quaternion.Euler(0, 0, 90); // ����
        //        break;
        //    case Direction.Right:
        //        transform.rotation = Quaternion.Euler(0, 0, -90); // ������
        //        break;
        //}

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


    

    //void Update()
    //{
        
    //}
}
