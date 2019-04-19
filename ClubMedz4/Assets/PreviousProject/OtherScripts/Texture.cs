using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetTextureOffset("m_Texture", new Vector2(2, 2));
    }

    // Update is called once per frame
    void Update()
    { 
}
}
