using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("0_StartScene");
    }

    public void BattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void DialogScene()
    {
        SceneManager.LoadScene("1_ImjinExplain");
    }
}
