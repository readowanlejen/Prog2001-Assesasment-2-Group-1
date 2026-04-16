using UnityEngine;
using UnityEngine.SceneManagement;

public class SharedMenuButtons : MonoBehaviour
{
    [Header("Help Popup")]
    public GameObject helpPanel;

    void Start()
    {
        // Make sure help panel is hidden
        if (helpPanel != null)
            helpPanel.SetActive(false);
    }

    void Update()
    {
    }

    // ── SCENE BUTTONS ─────────────────────

    public void GoToReadowanScene()
    {
        SceneManager.LoadScene("Demo_Snowman");
    }

    public void GoToNavodScene()
    {
        SceneManager.LoadScene("NavodScene");
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying
            = false;
#endif
    }

    // ── HELP POPUP ────────────────────────

    public void ShowHelp()
    {
        if (helpPanel != null)
            helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        if (helpPanel != null)
            helpPanel.SetActive(false);
    }
}
