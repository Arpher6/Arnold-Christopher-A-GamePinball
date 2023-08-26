using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditScreen : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
