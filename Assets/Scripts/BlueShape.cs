using UnityEngine;

// INHERITANCE: BlueShape inherits from the Shape parent class
public class BlueShape : Shape
{
    void Start()
    {
        ShapeName = "Blue Cylinder";
    }

    // POLYMORPHISM: Overriding the parent's virtual method to provide specific behavior
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent the depth of the ocean and the logic of the stars.");
    }
}