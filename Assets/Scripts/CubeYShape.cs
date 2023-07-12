using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritance
public class CubeYShape : BaseShape
{
    public CubeYShape()
    {
        this.Name = "CubeYGreen";
        this.Color = new Color(0.5f, 1f, 0.5f);
        this.Speed = 3.0f;
    }
    //Polymorphism
    public override void RotateShape()
    {
        transform.Rotate(Vector3.up, Speed);
    }

    private void OnMouseDown()
    {
        Debug.Log("CubeYGreen clicked");
        UpdateText(this.Name, this.Speed, "green"); //Abstraction
    }
}
