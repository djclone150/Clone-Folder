using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public void LoadLevel(string levelName)
    {
        Debug.Log("Loading level... " + levelName);
        //Loads the scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void QuitLevel()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
