using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class EnemyController_Boss : MonoBehaviour
{
    [SerializeField] private Transform targetPlayer;

    [SerializeField] private float patrolSpeed = 2f;

    [SerializeField] private float range = 0f;
    [SerializeField] private float distance;
    [SerializeField] public int moveFlag = 0;

    [SerializeField] private int hp = 10;

    private Vector3 move;

    private bool isTraceAtk = false;
    private bool isRealAtk = false;
    public GameObject boss;
    private bool isAttack = true;

    Animator animator;
    SpriteRenderer spriter;
    Rigidbody2D rgb2d;
    Collider2D coll;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        rgb2d = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponentInChildren<Animator>();
        StartCoroutine(PatrolMove());
    }

    private void FixedUpdate()
    {
        Move();
    }

    IEnumerator HitEffect()
    {
        spriter.color = new Color32(255, 255, 255, 160);
        yield return new WaitForSeconds(0.1f);
        spriter.color = new Color32(255, 255, 255, 255);
        yield return null;
    }

    IEnumerator PatrolMove()
    {
        moveFlag = Random.Range(-1, 2);
        if (moveFlag == 0)
        {
            animator.SetBool("isPatrol", false); // 걷는 모션 비활성화
        }
        else
        {
            animator.SetBool("isPatrol", true);  // 걷는 모션 활성화
        }

        yield return new WaitForSeconds(3f);

        StartCoroutine(PatrolMove());
    }

    IEnumerator NormalAttack()
    {
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Attack");
        boss.GetComponent<BossAttMgr>().BossAttack();
    }

    private void Move()
    {
        Vector3 movevelocity = Vector3.zero;
        distance = Vector3.Distance(transform.position, targetPlayer.position);
        string distFlag = "";

        if (distance <= range && !isTraceAtk)
        {
            Debug.Log("AA");
            isTraceAtk = true;
            if (isAttack)
            {
                animator.SetTrigger("Attack");
                boss.GetComponent<BossAttMgr>().BossAttack();
                isAttack = false;
            }
            StartCoroutine("NormalAttack");
        }
        else if (distance > range && isTraceAtk)
        {
            Debug.Log("BB");
            isTraceAtk = false;
            isAttack = true;
        }


        if (isTraceAtk)
        {
            Vector3 playerPos = targetPlayer.transform.position;
            movevelocity = Vector3.zero;

            if (playerPos.x < transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (playerPos.x > transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            //animator.SetTrigger(""); // 공격 애니메이션 적용
        }
        else
        {
            if (moveFlag == -1)
            {
                distFlag = "Left";
            }
            else if (moveFlag == 1)
            {
                distFlag = "Right";
            }
        }

        if (distFlag == "Left")
        {
            movevelocity = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (distFlag == "Right")
        {
            movevelocity = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position += movevelocity * patrolSpeed * Time.deltaTime;
    }
    public void TakeDamage(int dmg)
    {
        hp -= dmg;

        if (hp > 0)
        {
            StartCoroutine("HitEffect");
            
        }
        else
        {
            // 적 죽음 애니메이션 or 이펙트
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("R_EndPoint"))
        {
            moveFlag = -1;
        }
        else if (collision.CompareTag("L_EndPoint"))
        {
            moveFlag = 1;
        }

        if (collision.CompareTag("bullet"))
        {
            TakeDamage(3);
        }
        if (collision.CompareTag("L_Sword"))
        {
            TakeDamage(5);
        }
        if (collision.CompareTag("R_Sword"))
        {
            TakeDamage(5);
        }

    }

    

}


