using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string _shapeName;
    public string ShapeName
    {
        get => _shapeName;
        set => _shapeName = value;
    }

    public virtual void DisplayText()
    {
        UIManager.Instance.ShowMessage($"You clicked a shape!");
    }

    protected void OnMouseDown()
    {
        DisplayText();
    }
}