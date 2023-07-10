using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering;
using Unity.VisualScripting;

public class GunShot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletRPos;
    public Transform BulletLPos;
    GameObject bullet;
    public GameObject player;
    public void buttonDownAtt()
    {
        if(player.GetComponent<playerCtrl>().PV == PlayerVector.Right)
        {
            bullet = Instantiate(Bullet);
            bullet.transform.position = BulletRPos.position;
            Vector3 bulletVelocity = new Vector2(1.0f,0);
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000, 0));
            Destroy(bullet, 3.0f);
        }
       else  if (player.GetComponent<playerCtrl>().PV == PlayerVector.Left)
        {
            bullet = Instantiate(Bullet);
            bullet.transform.position = BulletLPos.position;
            Vector3 bulletVelocity = new Vector2(1.0f, 0);
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000, 0));
            Destroy(bullet, 3.0f);
        }


    }

    
}