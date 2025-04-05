using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float Health = 50;
    public float damager = 10;

    public stat stat;

    public Transform player;  // 플레이어의 Transform을 참조
    public float moveSpeed = 3f;  // 적의 이동 속도
    public float chaseRange = 10f;  // 추격 범위
    public float ContactRange = 0.8f;

    private Rigidbody2D rb;  // Rigidbody2D 컴포넌트
    private Vector2 moveDirection;  // 이동 방향

    //public Vector2 boxSize = new Vector2(1.0f, 1.0f); // OverlapBox 크기
    //public LayerMask groundLayer; // Ground 레이어를 설정
    //public GameObject pos; // OverlapBox의 중심 위치를 지정할 변수

    //float curTime;
    //float coolTime = 0.5f;

    // Start is called before the first frame update

    float distanceToPlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        distanceToPlayer = Vector2.Distance(transform.position, player.position);  // 플레이어와 적 간의 거리 계산
        //Debug.Log(distanceToPlayer);
        Debug.Log(Health);
        if (other.CompareTag("Player") )
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            if (distanceToPlayer <= ContactRange && stat.Invincibility <= 0)
            {
            stat.Damage(10);
            stat.Invincibility = stat.MaxInvincibility;
            }
            
        }
    }
    //private void OnTriggerEnter2D(BoxCollider2D other)
    //{
        
    //}
    public void TakeDamage(float damage)
    {
        Health -= damage;
    }


}
