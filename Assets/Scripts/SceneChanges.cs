using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChanges : MonoBehaviour
{
    public void ChangeScene(string levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void QuitGame()
    {
        print("Quit");
        Application.Quit();
    }
}
