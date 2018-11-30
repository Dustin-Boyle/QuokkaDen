using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour {

    public Color Color { get { return _color; } set { _color = value; GetComponent<MeshRenderer>().material.color = _color; } }
    Color _color;


    public void Start()
    {
        _color = new Color(1, 1, 1);
    }
}
