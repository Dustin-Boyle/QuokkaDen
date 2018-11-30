using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.InputSystem.Handlers;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;

public class PixelListener : MonoBehaviour,IMixedRealityFocusHandler, IMixedRealityInputHandler {

    public bool tapping = false;
    public Color initialColor;
    public Color currentColor;//the current picked color
    

    public void OnBeforeFocusChange(FocusEventData eventData)
    {

    }

    public void OnFocusChanged(FocusEventData eventData)
    {

    }

    public void OnFocusEnter(FocusEventData eventData)
    {
        if (tapping == true)
        {
           // Debug.Log("Selected" + eventData.selectedObject.name);
           // Debug.Log("Color" + eventData.selectedObject.GetComponent<Renderer>().material.color.ToString());

            //Find the gazed object, get the material and change the color to "CurrentColor"
            //eventData.selectedObject.GetComponent<Renderer>().material.color = currentColor;
            eventData.selectedObject.GetComponent<CubeColor>().Color = currentColor;
        }

    }

    public void OnFocusExit(FocusEventData eventData)
    {

    }

    public void OnInputDown(InputEventData eventData)
    {
        tapping = true;

    }

    public void OnInputPressed(InputEventData<float> eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
        tapping = false;
    }

    public void OnPositionInputChanged(InputEventData<Vector2> eventData)
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
