using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void BackBtn()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit Scene");
    }
}
