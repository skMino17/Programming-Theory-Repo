using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string _shapeName;

    [SerializeField] private Color shapeColor;

    // ENCAPSULATION: Getter for the color property
    public Color GetColor => shapeColor;

    // ENCAPSULATION: Using a property with a getter and setter to protect _shapeName
    public string ShapeName
    {
        get => _shapeName;
        set => _shapeName = value;
    }

    // POLYMORPHISM: Virtual method intended to be overridden by child classes
    public virtual void DisplayText()
    {
        UIManager.Instance.ShowMessage($"You clicked a shape!");
    }

    // ABSTRACTION: This method coordinates the high-level actions of clicking 
    // (UI message + Light change) without the user needing to manually call each system.
    protected void OnMouseDown()
    {
        DisplayText();
        // Tell the light to change color
        LightFollowMouse.Instance.UpdateLightColor(GetColor);
    }
}