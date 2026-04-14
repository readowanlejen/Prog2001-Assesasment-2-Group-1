using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // ── PLAY button ──────────────────────────
    // Loads your snowman dress-up scene
    public void OnPlayClicked()
    {
        SceneManager.LoadScene("SnowmanScene");
        // Change "SnowmanScene" to whatever
        // you named your scene file
    }

    // ── MENU button ──────────────────────────
    // Reloads this menu scene (resets everything)
    public void OnMenuClicked()
    {
        SceneManager.LoadScene("Demo_Snowman");
        // Change "Demo_Snowman" to your
        // menu scene name if different
    }

    // ── QUIT button ──────────────────────────
    // Quits the game
    public void OnQuitClicked()
    {
        // This works in built game
        Application.Quit();

        // This stops play mode inside Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
