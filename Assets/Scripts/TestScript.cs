using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Material NeededMaterial;
    public MeshRenderer currentMesh;
    public Material currentmaterial;
    // Start is called before the first frame update
    void Start()
    {
        currentMesh = GetComponentInChildren<MeshRenderer>();
        currentmaterial = currentMesh.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentmaterial.color == NeededMaterial.color)
        {
            Destroy(gameObject);
        }
        
    }
}
