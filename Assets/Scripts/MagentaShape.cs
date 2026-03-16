using UnityEngine;

public class MagentaShape : Shape
{
    void Start()
    {
        ShapeName = "Magenta Cylinder";
    }

    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am the {ShapeName}. I represent the spark of imagination and hidden power.");
    }
}