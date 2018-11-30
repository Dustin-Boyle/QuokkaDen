using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.InputSystem.Handlers;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAll : MonoBehaviour, IMixedRealityPointerHandler {
    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        ClearAllButton();
        //throw new System.NotImplementedException();
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    private void ClearAllButton()
    {
        Color clear_color = new Color(1, 1, 1);
        //Find all components of type CubeColor
        List<CubeColor> my_cube_list = new List<CubeColor>();
        my_cube_list.AddRange(GameObject.FindObjectsOfType<CubeColor>());
        
        for (int i = 0; i < my_cube_list.Count; i++)
        {
            my_cube_list[i].Color = clear_color;
        }
        
    }
}
