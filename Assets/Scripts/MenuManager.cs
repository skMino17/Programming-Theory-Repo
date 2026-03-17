using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameField;

    // ABSTRACTION: Hiding the details of saving data and loading scenes 
    // behind a single "Start" button interaction.

    public void StartGame()
    {
        if (MainManager.Instance != null)
        {
            MainManager.Instance.PlayerName = nameField.text;
        }

        SceneManager.LoadScene("main");
    }
}