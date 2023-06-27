using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLeft : MonoBehaviour
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
        this.transform.localScale = new Vector3(1f, 10f, 21f);
        this.transform.position = new Vector3(-ResolutionResultWidth * 10.125f, 5f, 0f);
    }
}
