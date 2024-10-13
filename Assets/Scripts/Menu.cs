using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
public void Play()
{
        SceneManager.LoadScene(2);  // Loads the scene with build index 0
}
public void Quit()
{
    Application.Quit();
    Debug.Log("Player has Quit The Game");
}

    public void LoadOptions()
    {
        SceneManager.LoadScene(1);  // Loads the scene with build index 0
    }
        public void Return()
    {
        SceneManager.LoadScene(0);  // Loads the scene with build index 0
    }
}
