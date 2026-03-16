using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameField;

    public void StartGame()
    {
        if (MainManager.Instance != null)
        {
            MainManager.Instance.PlayerName = nameField.text;
        }

        SceneManager.LoadScene("main");
    }
}