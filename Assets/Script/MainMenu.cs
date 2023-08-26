using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton ()
    {
        SceneManager.LoadScene("Game");
    }
    public void CreditButton () {
        SceneManager.LoadScene("Credit");
    }
    public void QuitButton () {
        Application.Quit();
    }
}
