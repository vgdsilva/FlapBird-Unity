using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    public float AnimationSpeed = 1f;
    private MeshRenderer MeshRenderer;


    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        MeshRenderer.material.mainTextureOffset += new Vector2(AnimationSpeed * Time.deltaTime, 0);
    }
}
