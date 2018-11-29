using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterMaze : MonoBehaviour {

    public string gameScene;

    public void StartGame()
    {
        Debug.Log("StartGame is called");
        SceneManager.LoadScene(gameScene);
    }
}
