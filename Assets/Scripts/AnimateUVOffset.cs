using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUVOffset : MonoBehaviour
{
    Renderer rend;
    Global globalRef;

    public float Multiplicateur = 1;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        globalRef = FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = rend.material.GetTextureOffset("_MainTex");

        offset.y += Multiplicateur * globalRef.Speed * Time.deltaTime;

        rend.material.SetTextureOffset("_MainTex", offset);
    }
}
