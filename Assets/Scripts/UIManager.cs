using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Main UI")]
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI infoText;

    [Header("Welcome UI")]
    [SerializeField] private GameObject welcomePanel;
    [SerializeField] private TextMeshProUGUI welcomeText;

    void Awake() { Instance = this; }

    void Start() { ShowWelcomeMessage(); }

    // ABSTRACTION: This method hides the complexity of UI state management.
    // The caller doesn't need to know that we are turning off the welcome panel, 
    // enabling the main panel, and updating text all at once.

    public void ShowMessage(string message)
    {
        uiPanel.SetActive(true);
        infoText.text = message;

        if (welcomePanel != null && welcomePanel.activeSelf)
        {
            welcomePanel.SetActive(false);
        }

        uiPanel.SetActive(true);
        infoText.text = message;
    }

    private void ShowWelcomeMessage()
    {
        string name = "Player";
        if (MainManager.Instance != null && !string.IsNullOrEmpty(MainManager.Instance.PlayerName))
        {
            name = MainManager.Instance.PlayerName;
        }

        welcomeText.text = $"Welcome to Cylinders, {name}! Click on a Cylinder to start.";
        welcomePanel.SetActive(true);
    }
}