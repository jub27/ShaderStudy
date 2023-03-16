using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitScript : MonoBehaviour
{
    public Renderer _renderer;
    public Texture2D texture2D;
    public Texture2DArray texture2DArray;
    public Texture3D texture3D;
    public Cubemap cubemap;

    // Start is called before the first frame update
    void Start()
    {
        _renderer.material.SetFloat("_Metallic", 1.0f);
        _renderer.material.SetColor("_BaseColor", new Color(1,0,0,1));
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.material.SetColor("_BaseColor", new Color(Random.Range(0,1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f)));
    }
}
