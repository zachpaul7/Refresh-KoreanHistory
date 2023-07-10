using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInout : MonoBehaviour
{
    public Image FadeOutImage;

    private void OnEnable()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        var FadeTime = new WaitForSeconds(0.01f);

        float f = 0;

        while(f < 1.0f)
        {
            f += 0.01f;
            yield return FadeTime;
            FadeOutImage.color = new Color(0, 0, 0, f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
