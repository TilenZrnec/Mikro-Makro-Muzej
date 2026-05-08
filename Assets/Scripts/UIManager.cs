using TMPro;
using Unity.VectorGraphics;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject popUp;
    public GameObject player;
    public TextMeshProUGUI menuText;

    void Start()
    {
        popUp.SetActive(false);
        menuText.text = "MENU";
    }

    void Update()
    {
        scoreText.text = "Coins: " + GameManager.score;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowPopUp();
        }
    }

    public void ShowPopUp()
    {
        popUp.SetActive(true);
        player.SetActive(false);
        Cursor.visible = true;                      // Make it visible
        Cursor.lockState = CursorLockMode.None;     // Let it move freely
    }

    public void HidePopUp()
    {
        popUp.SetActive(false);
        player.SetActive(true);
        Cursor.visible = false;                     // Hide the cursor
        Cursor.lockState = CursorLockMode.Locked;    // Lock the cursor
        menuText.text = "MENU";
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f; // Resume the game 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Load the previous scene (main menu)
    }
}