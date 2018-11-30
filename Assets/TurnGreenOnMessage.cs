using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGreenOnMessage : MonoBehaviour {

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Should_Turn_Green();
        }
    }

    public void Should_Turn_Green()
    {
        Debug.Log("Turning green!");
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);

    }

}
