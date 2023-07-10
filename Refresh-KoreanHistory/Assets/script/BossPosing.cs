using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPosing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Player.GetComponent<playerCtrl>().life -= 10;
            Destroy(this.gameObject);
        }
      
    }

}
