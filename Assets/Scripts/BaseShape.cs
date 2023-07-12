using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseShape : MonoBehaviour
{
    public Text shapeDetailsText;
    protected string shapeDetails;
    
    //Encapsulation
    public string Name {  get; set; }
    public Color Color {  get; set; }
    public float Speed { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color;
        shapeDetailsText.text = "Select shape";
    }

    // Update is called once per frame
    void Update()
    {
        RotateShape();
    }

    public virtual void RotateShape() { }

    public void UpdateText(string name, float speed, string color)
    {
        shapeDetailsText.text = $"{name} \nSpeed:{speed} \nColor:{color}";
    }
}
