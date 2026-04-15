using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonFunctions : MonoBehaviour
{
    [Header("Feedback")]
    public TextMeshProUGUI feedbackText;

    void Start()
    {
    }

    void Update()
    {
    }

    public void GoToSnowmanScene()
    {
        SceneManager.LoadScene("SnowManScene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Demo_Snowman");
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying
            = false;
#endif
    }

    public void TakeScreenshot()
    {
        StartCoroutine(Screenshot());
    }

    IEnumerator Screenshot()
    {
        // Wait for end of frame
        yield return new WaitForEndOfFrame();

        // Take screenshot
        string name = "Snowman_" +
            System.DateTime.Now.ToString(
            "yyyyMMdd_HHmmss") + ".png";
        ScreenCapture.CaptureScreenshot(name);
        Debug.Log("Saved: " + name);

        // Show feedback message
        if (feedbackText != null)
        {
            StartCoroutine(ShowMessage());
        }
    }

    IEnumerator ShowMessage()
    {
        // Show the text
        feedbackText.gameObject.SetActive(true);
        feedbackText.text = "📸 Screenshot Saved!";

        // Wait 2 seconds
        yield return new WaitForSeconds(2f);

        // Hide the text
        feedbackText.gameObject.SetActive(false);
    }
}
