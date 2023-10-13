using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public GameObject wristUI;

    public bool activeWristUI;

    public void StartBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(1);
        LaunchProjectile.shot = false;
        //TestBall.touch = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Start()
    {
        DisplayWristUI();
    }

    public void WristMenuPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayWristUI();
        }
    }

    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
        }
        else if (!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}