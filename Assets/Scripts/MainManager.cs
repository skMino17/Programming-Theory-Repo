using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    // ENCAPSULATION: Using a property with a getter and setter to protect data
    public string PlayerName { get; set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}