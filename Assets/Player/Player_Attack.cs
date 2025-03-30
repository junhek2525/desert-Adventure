using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Vector2 boxSize = new Vector2(1.0f, 1.0f); // OverlapBox 크기
    public LayerMask groundLayer; // Ground 레이어를 설정
    public GameObject pos; // OverlapBox의 중심 위치를 지정할 변수
    Rigidbody2D rb;
    float curTime;
    float coolTime = 0.5f;


    public stat stat;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] hit = Physics2D.OverlapBoxAll (pos.transform.position, boxSize, 0f);
        if (curTime <= 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                foreach (Collider2D collider in hit)
                {
                    if (collider.tag == "enemy")
                    {
                        collider.GetComponent<enemy>().TakeDamage(/*stat.Damager*/10);

                    }
                    if (collider.tag == "Launcher")
                    {
                        collider.GetComponent<Launcher>().shot();

                    }
                }
                curTime = coolTime;
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(pos.transform.position, boxSize); // pos를 중심으로 OverlapBox 위치와 크기를 시각적으로 확인
    }

}
