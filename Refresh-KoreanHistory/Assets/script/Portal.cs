using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Portal : MonoBehaviour
{

    public string transferMapName;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("충돌");
            //SceneManager.LoadScene(transferMapName);
            SceneManager.LoadScene(transferMapName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
