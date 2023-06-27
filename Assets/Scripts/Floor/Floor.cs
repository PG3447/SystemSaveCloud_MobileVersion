using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private float Height;
    private float Width;
    private float ResolutionResultWidth;


    void Start()
    {
        Width = Screen.currentResolution.width;
        Height = Screen.currentResolution.height;
        ResolutionResultWidth = Width / Height;
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
    void Update()
    {
        Width = Screen.currentResolution.width;
        Height = Screen.currentResolution.height;
        ResolutionResultWidth = Width / Height;
        this.transform.localScale = new Vector3(ResolutionResultWidth * 2.25f, 1f, 2.1f);
    }
}
