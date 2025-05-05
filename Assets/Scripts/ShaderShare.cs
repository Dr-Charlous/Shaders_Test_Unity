using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShaderShare : MonoBehaviour
{
    public Transform Object;
    [SerializeField] Material _mat;

    private void Update()
    {
        if (_mat != null)
            _mat.SetVector("_Position", Object.position);
    }
}