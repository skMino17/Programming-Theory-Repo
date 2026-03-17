using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string _shapeName;

    [SerializeField] private Color shapeColor;
    public Color GetColor => shapeColor;
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
        // Tell the light to change color
        LightFollowMouse.Instance.UpdateLightColor(GetColor);
    }
}