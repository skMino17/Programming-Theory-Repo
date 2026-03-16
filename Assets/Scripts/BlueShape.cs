using UnityEngine;

public class BlueShape : Shape
{
    void Start()
    {
        ShapeName = "Blue Cylinder";
    }

    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent the depth of the ocean and the logic of the stars.");
    }
}