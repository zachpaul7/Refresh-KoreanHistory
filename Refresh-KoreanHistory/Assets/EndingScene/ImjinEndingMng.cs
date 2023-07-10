using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImjinEndingMng : MonoBehaviour
{
    public Image FadeOutImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FadeOutImage.color.a >= 0.9f)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
