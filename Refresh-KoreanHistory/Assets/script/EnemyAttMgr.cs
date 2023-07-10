using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttMgr : MonoBehaviour
{
    public Transform enemyRPos;
    public Transform enemyLPos;
    public GameObject enemyL;
    public GameObject enemyR;
    public GameObject import_Enemy;
    public GameObject Player;
    GameObject enemyl;
    GameObject enemyr;

    public void EnemyAtt()
    {
        if (import_Enemy.GetComponent<EnemyController>().moveFlag == 1)
        {
            enemyr = Instantiate(enemyR);
            enemyr.transform.position = enemyRPos.transform.position;
            //Player.GetComponent<playerCtrl>().life -= 1;
            Vector3 bulletVelocity = new Vector2(1.0f, 0);
            Destroy(enemyr, 0.5f);
        }
        else if (import_Enemy.GetComponent<EnemyController>().moveFlag == -1)
        {
            enemyl = Instantiate(enemyL);
            enemyl.transform.position = enemyLPos.transform.position;
            //Player.GetComponent<playerCtrl>().life -= 1;
            Vector3 bulletVelocity = new Vector2(1.0f, 0);
            Destroy(enemyl, 0.5f);
        }
    }
}
