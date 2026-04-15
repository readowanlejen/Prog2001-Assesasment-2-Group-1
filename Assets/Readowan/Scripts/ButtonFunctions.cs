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

    // ── DEMO SNOWMAN BUTTONS ──────────────

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

    // ── RESET BUTTON ──────────────────────

    public void ResetAllAccessories()
    {
        AccessoryPlacer[] allAccessories =
            FindObjectsByType<AccessoryPlacer>(
            FindObjectsSortMode.None);

        foreach (AccessoryPlacer acc
            in allAccessories)
        {
            acc.ResetAccessory();
        }

        Debug.Log("All accessories reset!");

        if (feedbackText != null)
            StartCoroutine(ShowMessage(
                "Snowman Reset!"));
    }

    // ── FEEDBACK MESSAGE ──────────────────

    IEnumerator ShowMessage(string message)
    {
        if (feedbackText == null) yield break;
        feedbackText.text = message;
        feedbackText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        feedbackText.gameObject.SetActive(false);
    }
}