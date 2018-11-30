using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.InputSystem.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHandler : MonoBehaviour, IMixedRealityPointerHandler
{
    public Color ChoosenColor;
    public Color Color { get { return _color; } set { _color = value; GetComponent<MeshRenderer>().material.color = _color; } }
    Color _color;
    PixelListener pListener;
    public List<Color[]> colors = new List<Color[]>();

    public void Start()
    {
        pListener = GetComponent<PixelListener>();
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        // Color = Color.HSVToRGB(Random.value, 0.4f, 0.8f);

        ChoosenColor = pListener.currentColor;
        if (ChoosenColor != null)
        Color = ChoosenColor;

       // Renderer[] renderers = GetComponentsInChildren<Renderer>();
       // for (int i = 0; i < renderers.Length; i++)
       // {
       //     foreach (Renderer renderer in renderers)
       //     {
       //         renderers[i].Color = colors[i];
       //     }
    }
    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
    }
    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
    }
}

