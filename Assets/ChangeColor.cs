using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.InputSystem.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IMixedRealityPointerHandler
{

    public Color my_color;
    public PixelListener pl_reference;

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        pl_reference.currentColor = my_color;
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
//        throw new System.NotImplementedException();
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
//        throw new System.NotImplementedException();
    }
}
