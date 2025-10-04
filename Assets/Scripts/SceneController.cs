using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadMainMenuScene()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("TitleScene");
    }

    public void LoadMadDriverScene()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("Prototype 1");
    }

    public void LoadPrototype4Scene()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("Prototype 4");
    }

    public void LoadChallenge1()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("Challenge 1");
    }

    // Restart Prototype 1 scene
    public void RestartPrototype1()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("Prototype 1");
    }

    public void RestartPrototype4()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("Prototype 4");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); // Only visible in the editor
        Application.Quit(); // Quits the game (works in build)
        EditorApplication.isPlaying = false;
    }

}
