using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ExplainMng : MonoBehaviour
{
    public string[] MessageArray;

    public TextMeshProUGUI DialogText;

    public float TypingSpeed = 0.3f;
    public float NextDiaSpeed = 2.0f;

    public int j = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Typing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Typing()
    {
        var Speed = new WaitForSeconds(TypingSpeed);
        var NextSpeed = new WaitForSeconds(NextDiaSpeed);

        for(int i = 0; i < MessageArray[j].Length; i++)
        {
            DialogText.text = MessageArray[j].Substring(0, i + 1);
            yield return Speed;
        }

        j++;

        yield return NextSpeed;

        if(j < MessageArray.Length) 
        {
            StartCoroutine(Typing());
        }
        if(j == MessageArray.Length)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
