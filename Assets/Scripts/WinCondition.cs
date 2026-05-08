using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WinCondition : MonoBehaviour
{
    public int coinsToWin = 5;
    public UIManager uiManager;
    private bool hasWon = false;


    void Update()
    {
        if (GameManager.score >= coinsToWin && !hasWon)
        {
            // LoadWinScene();
            uiManager.menuText.text = "YOU WIN!";
            uiManager.ShowPopUp();
            hasWon = true;
        }
    }

    // void LoadWinScene()
    // {
    //     SceneManager.LoadScene("WinScene");
    // }
}