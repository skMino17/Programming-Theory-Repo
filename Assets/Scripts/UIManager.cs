using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject uiPanel;
    [SerializeField] private TextMeshProUGUI infoText;

    void Awake()
    {
        Instance = this;
    }

    public void ShowMessage(string message)
    {
        uiPanel.SetActive(true);
        infoText.text = message;
    }
}