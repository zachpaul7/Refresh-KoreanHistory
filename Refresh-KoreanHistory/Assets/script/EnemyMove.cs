using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigd;
    public int nextMove;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Awake()
    {
        rigd = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        Invoke("AI", 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigd.velocity = new Vector2(-1, rigd.velocity.y);

        //Platform Check

        Vector2 frontVec = new Vector2(rigd.position.x + nextMove * 0.3f, rigd.position.y);
        Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(frontVec, Vector3.down, 1, LayerMask.GetMask("Platforms"));
        if (rayHit.collider == null)
        {
            Debug.Log("경고! 이 앞 낭떠러지다");
            Turn();
        }

    
    }

    void AI()
    {
        nextMove = UnityEngine.Random.Range(-1, 2);

        float nextThinkTime = Random.Range(2f, 5f);
        Invoke("AI", nextThinkTime);
    }

    void Turn()
    {
        nextMove *= -1;
        renderer.flipX = nextMove == 1;
        CancelInvoke();
        Invoke("AI", 5);
    }
}
