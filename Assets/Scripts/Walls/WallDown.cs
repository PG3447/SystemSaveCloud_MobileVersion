using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDown : MonoBehaviour
{
    private float Height;
    private float Width;
    private float ResolutionResultWidth;


    void Start()
    {
        Width = Screen.currentResolution.width;
        Height = Screen.currentResolution.height;
        ResolutionResultWidth = Width / Height;
    }
    void Update()
    {
        Width = Screen.currentResolution.width;
        Height = Screen.currentResolution.height;
        ResolutionResultWidth = Width / Height;
        this.transform.localScale = new Vector3(ResolutionResultWidth * 19.6875f, 10f, 1f);
        this.transform.position = new Vector3(0f, 5f, -10f);
    }
}
