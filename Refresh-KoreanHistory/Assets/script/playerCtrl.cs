using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public enum PlayerState
{
    idle, Run, Jump, Att, Death
}

public enum PlayerVector
{
     Right, Left
}
public class playerCtrl : MonoBehaviour
{
    [SerializeField] private PlayerHP_Controller playerHP_Controller;
    public int life = 10;
    public float f_jumpPower = 400f;
    public AudioClip[] Sound;
    public Animator anim;
    public PlayerState PS;
    public PlayerVector PV;
    public GameObject RenderObj;
    public bool LeftMove = false;
    public bool RightMove = false;
   public float f_playerSpeed = 1.1f;
    Vector3 moveVelocity = Vector3.zero;
    int jumpCount = 0;
    // Update is called once per frame
    
    private void FixedUpdate()
    {
       if(LeftMove)
        {
            moveVelocity = new Vector3(-1f, 0, 0);
            transform.position += moveVelocity* f_playerSpeed * Time.deltaTime;
        }
       if(RightMove)
        {
            moveVelocity = new Vector3(+1f, 0, 0);
            transform.position += moveVelocity * f_playerSpeed * Time.deltaTime;
        }
    }

 
    public void ButtonDownLeft()
    {
        PS = PlayerState.Run;
        PV = PlayerVector.Left;
        LeftMove = true;
        anim.SetBool("Run", true);
        RenderObj.GetComponent<SpriteRenderer>().flipX = true;
        
    }
    public void ButtonUpLeft()
    {

        anim.SetBool("Run", false);
        LeftMove = false;

    }
    public void ButtonDownRight()
    {
       RightMove = true;
       PS = PlayerState.Run;
       PV = PlayerVector.Right;
      
       anim.SetBool("Run", true);
       RenderObj.GetComponent<SpriteRenderer>().flipX = false;
    }
    public void ButtonUpRight()
    {
        RightMove = false;
        anim.SetBool("Run", false);
    }
    
    public void ButtonDonwJump()
    {
        Jump();
    }

    public void ButtonAtt()
    {
        PS = PlayerState.Att;    
        anim.SetTrigger("Att");
   
        if (PV == PlayerVector.Left)
        {
            soundPlay(0, GetAudioClip(0));
            RenderObj.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (PV == PlayerVector.Right)
        {
            soundPlay(0, GetAudioClip(0));
            RenderObj.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
    void Jump()
    {
        PS = PlayerState.Jump;
        jumpCount++;
        if(jumpCount ==1)
        {
            anim.SetTrigger("Jump");
            soundPlay(1, GetAudioClip(1));
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,f_jumpPower));
        }
        
    }
    void GameOver()
    {
        PS = PlayerState.Death;
        SceneManager.LoadScene("DeathScene");
    }

    
 
    private AudioClip GetAudioClip(int Num)
    {
        return Sound[Num];
    }
    void soundPlay(int Num, AudioClip audioClip)
    {
        GetComponent<AudioSource>().clip = audioClip;
        GetComponent<AudioSource>().Play();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) //적 무기 태그 설정
        {
            life--;
            if(life <= 0)
            {
                GameOver();
            }
        }
        else if(collision.CompareTag("R_bossAtt"))
        {
            life--;
            if (life <= 0)
            {
                GameOver();
            }
        }
        else if(collision.CompareTag("L_bossAtt"))
        {
            life--;
            if (life <= 0)
            {
                GameOver();
            }
        }
        else if(collision.CompareTag("Enemy_Att"))
        {
            life--;
            if (life <= 0)
            {
                GameOver();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Gound")
        {
            PS = PlayerState.Run;
            jumpCount = 0;
        }
        if (col.gameObject.tag == "2floor")
        {
            PS = PlayerState.Run;
            jumpCount = 0;
        }
        if(col.gameObject.tag == "potal1")
        {
            SceneManager.LoadScene(""); // boss room 입장
        }
    }
}

