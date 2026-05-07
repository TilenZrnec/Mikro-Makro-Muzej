using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public int coinsToWin = 5;

    void Update()
    {
        if (GameManager.score >= coinsToWin)
        {
            LoadWinScene();
        }
    }

    void LoadWinScene()
    {
        SceneManager.LoadScene("WinScene");
    }
}