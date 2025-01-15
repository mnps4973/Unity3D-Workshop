using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void EndGame(){
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void RestartGame(){
        SceneManager.LoadScene("SampleScene");
    }
}
