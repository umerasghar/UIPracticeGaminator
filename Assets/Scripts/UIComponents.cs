using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class UIComponents 
{
    [Header("UI components")]
    public Button pressbtn;
    public Image img;
    public RawImage renderview;
    public InputField input;
    public Text txt;
    public ScrollRect scroll;
    public Slider sliderx;
    public Slider slidery;
    public Slider sliderz;
    public Toggle slidertoggle;
    public Toggle scrollreacttoggle;
    public ScrollRect scrollrect;
    public Dropdown colordropdown;
    [Header("Panels/Screens")]
    public GameObject LayoutPanel;
    public GameObject MainPanel;
}
