using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public void GoToTitleScreen()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
