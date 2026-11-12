using UnityEngine;

public class MaterialUpdated : MonoBehaviour
{
    public GameObject reference;
    public string PivotName;
    
    void Update()
    {
        //var renderer = GetComponent<MeshRenderer>();
       // renderer.material.SetVector(PivotName, reference.transform.position);
       Shader.SetGlobalVector(PivotName, reference.transform.position);
    }
}
