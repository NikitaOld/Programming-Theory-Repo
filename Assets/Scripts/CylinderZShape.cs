using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class CylinderZShape : BaseShape
{
    public CylinderZShape()
    {
        this.Name = "CylinderZBlue";
        this.Color = new Color(0.5f, 0.5f, 1f);
        this.Speed = 3.0f;
    }
    //Polymorphism
    public override void RotateShape()
    {
        transform.Rotate(Vector3.forward, Speed);
    }

    private void OnMouseDown()
    {
        Debug.Log("CylinderZBlue clicked");
        UpdateText(this.Name, this.Speed, "blue"); //Abstraction
    }
}
