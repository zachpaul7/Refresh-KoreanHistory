using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttMgr : MonoBehaviour
{
    public GameObject bossR;
    public GameObject bossL;
    public Transform bossRPos;
    public Transform bossLPos;
    public GameObject boss;
    public GameObject Player;
    GameObject bossr;
    GameObject bossl;

    public void BossAttack()
    {
        if (boss.GetComponent<BossMove>().moveFlag == 1)
        {
            bossr = Instantiate(bossR);
            bossr.transform.position = bossRPos.transform.position;
            Player.GetComponent<playerCtrl>().life -= 1;
            Destroy(bossr, 1f);
        }
        else if (boss.GetComponent<BossMove>().moveFlag == -1)
        {
            bossl = Instantiate(bossL);
            bossl.transform.position = bossLPos.transform.position;
            Player.GetComponent<playerCtrl>().life -= 1;
            Destroy(bossl, 1f);
        }
    }
   

}
