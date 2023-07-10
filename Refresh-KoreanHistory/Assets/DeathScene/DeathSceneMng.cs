using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.TextCore.Text;
using System;

public class DeathSceneMng : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Text_01;

    [SerializeField]
    private TextMeshProUGUI Text_02;

   
    public GameObject buttonPanel;


    // Start is called before the first frame update
    void Start()
    {
        buttonPanel.SetActive(false);
        StartCoroutine(AlphaText_01());
    }

    IEnumerator AlphaText_01()
    {
        var returnTime = new WaitForSeconds(0.01f);
        float FadeColor = 0;
        
        while(FadeColor < 1.0f)
        {
            FadeColor += 0.01f;
            yield return returnTime;
            Text_01.color = new Color(Text_01.color.r, Text_01.color.g, Text_01.color.b, FadeColor);
        }

        if (Text_01.color.a >= 0.9f)
        {
            StartCoroutine(AlphaText_02());
        }
    }

    IEnumerator AlphaText_02()
    {
        var returnTime = new WaitForSeconds(0.01f);
        var WaitTime = new WaitForSeconds(3f);

        yield return WaitTime;

        float FadeColor = 0;

        while(FadeColor < 1.0f)
        {
            FadeColor += 0.01f;
            yield return returnTime;
            Text_02.color = new Color(Text_02.color.r, Text_02.color.g, Text_02.color.b, FadeColor);
        }

        if (Text_02.color.a >= 0.9f)
        {
            yield return new WaitForSeconds(0.4f);
            buttonPanel.SetActive(true);
        }
    }


    // 추후에 프로젝트 합치고 구현
    IEnumerator AlphaText_03()
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        //yield return returnTime;

        //StopAllCoroutines();
    }
}
