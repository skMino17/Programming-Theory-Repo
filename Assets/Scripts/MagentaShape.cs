using UnityEngine;

// INHERITANCE: MagentaShape inherits from the Shape parent class
public class MagentaShape : Shape
{
    void Start()
    {
        ShapeName = "Magenta Cylinder";
    }

    // POLYMORPHISM: Overriding the parent's virtual method to provide specific behavior
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent the spark of imagination and hidden power.");
    }
}