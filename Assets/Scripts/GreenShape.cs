using UnityEngine;

// INHERITANCE: GreenShape inherits from the Shape parent class
public class GreenShape : Shape
{
    void Start()
    {
        ShapeName = "Green Cylinder";
    }

    // POLYMORPHISM: Overriding the parent's virtual method to provide specific behavior
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent life, energy, and constant evolution.");
    }
}