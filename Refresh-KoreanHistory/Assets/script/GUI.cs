using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GUI : MonoBehaviour
{
    internal static object skin;


    public void AppQuit()
    {
        Application.Quit();
        Debug.Log("∞‘¿” ≥°");
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}