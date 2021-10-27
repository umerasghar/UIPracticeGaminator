using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class UIComponents 
{
    [Header("UI components")]
    public RawImage renderview;
    public Slider sliderx;
    public Slider slidery;
    public Slider sliderz;
    public Toggle slidertoggle;
    public Toggle scrollreacttoggle;
    public Toggle showall;
    public ScrollRect scrollrect, scrollrect2;
    public Dropdown colordropdown;
    [Header("Panels/Screens")]
    public GameObject LayoutPanel;
    public GameObject MainPanel;
    public GameObject GameScreen;
    public GameObject GameScreenPort;
    public GameObject Popup;
}
