using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class UIComponents 
{
    [Header ("Buttons")]
    public Button bttn;
    [Header("Images")]
    public Image img;
    [Header("Input")]
    public InputField input;
    [Header("Text")]
    public Text txt;
    [Header("Scroll")]
    public ScrollRect scroll;
    [Header("Slider")]
    public Slider slider;
    [Header("Toggle")]
    public Toggle toggle;
}
