using UnityEngine;
using UnityEngine.SceneManagement;

public class SharedMenuButtons : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

    // Readowan's Scene button
    public void GoToReadowanScene()
    {
        SceneManager.LoadScene("Demo_Snowman");
    }

    // Navod's Scene button
    public void GoToNavodScene()
    {
        SceneManager.LoadScene("NavodScene");
    }

    // Quit button
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying
            = false;
#endif
    }
}
