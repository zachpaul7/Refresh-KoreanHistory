using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneMng : MonoBehaviour
{
    public void OnClickNextSceneBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickExitSceneBtn()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }
}
