using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class CylinderXShape : BaseShape
{
    public CylinderXShape()
    {
        this.Name = "CylinderXRed";
        this.Color = new Color(1f, 0.5f, 0.5f);
        this.Speed = 3.0f;
    }
    //Polymorphism
    public override void RotateShape()
    {
        transform.Rotate(Vector3.right, Speed);
    }

    private void OnMouseDown()
    {
        Debug.Log("CylinderXRed clicked");
        UpdateText(this.Name, this.Speed, "red"); //Abstraction
    }
}
