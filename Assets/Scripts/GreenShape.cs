using UnityEngine;

public class GreenShape : Shape
{
    void Start()
    {
        ShapeName = "Green Cylinder";
    }

    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent life, energy, and constant evolution.");
    }
}