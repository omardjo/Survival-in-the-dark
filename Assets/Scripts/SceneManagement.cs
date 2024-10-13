using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
  // Function to load scene at index 0
    public void LoadHome()
    {
        SceneManager.LoadScene(2) ; // Loads the scene with build index 1
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene(1) ; // Loads the scene with build index 1
    }
      public void LoadMenu()
    {
        SceneManager.LoadScene(0) ; // Loads the scene with build index 1
    }
    // Function to load scene at index 1
    public void LoadScene1()
    {
        SceneManager.LoadScene(3) ; // Loads the scene with build index 1
    }

    // Function to load scene at index 2
    public void LoadScene2()
    {
        SceneManager.LoadScene(4);  // Loads the scene with build index 2
    }

    // Function to load scene at index 3
    public void LoadScene3()
    {
        SceneManager.LoadScene(5);  // Loads the scene with build index 3
    }
   public void LoadScene4()
    {
        SceneManager.LoadScene(6);  // Loads the scene with build index 3
    }
       public void LoadScene5()
    {
        SceneManager.LoadScene(7);  // Loads the scene with build index 3
    }
       public void LoadScene6()
    {
        SceneManager.LoadScene(8);  // Loads the scene with build index 3
    }
      public void Return()
    {
        SceneManager.LoadScene(0);  // Loads the scene with build index 3
    }
    // Add more functions as needed for other scene indices
}
