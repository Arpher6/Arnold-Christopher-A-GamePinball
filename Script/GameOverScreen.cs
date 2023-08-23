using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void RetryButtonn()
    {
        SceneManager.LoadScene("Game");
    }
    public void MenuButtonn()
    {
        SceneManager.LoadScene("Menu");
    }
}
