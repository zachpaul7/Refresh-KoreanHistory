using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwordMgr : MonoBehaviour
{
    public GameObject swordR;
    public GameObject swordL;
    public Transform swordRPos;
    public Transform swordLPos;
    public GameObject player;
    GameObject swordr;
    GameObject swordl;

    public void buttonDownAtt()
    {
        if (player.GetComponent<playerCtrl>().PV == PlayerVector.Right)
        {
            swordr = Instantiate(swordR);
            swordr.SetActive(true);
            swordr.transform.position = swordRPos.position;
            Destroy(swordr, 1f);
        }
        else if (player.GetComponent<playerCtrl>().PV == PlayerVector.Left)
        {
            swordl = Instantiate(swordL);
            swordl.SetActive(true);
            swordl.transform.position = swordLPos.position;
            Destroy(swordl, 1f);
        }
    }
    
}
