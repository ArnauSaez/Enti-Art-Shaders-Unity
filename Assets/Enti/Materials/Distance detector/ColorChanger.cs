using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color InColor;
    public Color OutColor;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var renderer = GetComponent<MeshRenderer>();
        renderer.material.SetColor("_OutColor", OutColor);
        renderer.material.SetColor("_InColor", InColor);
    }

    
}
