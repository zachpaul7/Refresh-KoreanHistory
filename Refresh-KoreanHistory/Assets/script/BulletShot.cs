using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
        if(col.CompareTag("2floor"))
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "2floor")
        {
            Destroy(this.gameObject);
        }
    }
}
