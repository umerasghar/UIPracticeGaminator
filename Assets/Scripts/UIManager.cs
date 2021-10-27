using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UIComponents components;
    public GameObject sphere;
    Material spherematerial;
    Animator popup;
    bool portrait, landscape;
    // Start is called before the first frame update
    private void Awake()
    {
        landscape = true;
        portrait = false;
        SetOrientation();
        instance = this;
    }
    void Start()
    {

        
        spherematerial = sphere.GetComponent<Renderer>().material;
        popup = components.Popup.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetOrientation()
    {
        if (portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        if (landscape)
        {
            Screen.orientation = ScreenOrientation.Landscape;
          //  Screen.orientation = ScreenOrientation.AutoRotation;
            //Screen.autorotateToPortrait = false;
            //Screen.autorotateToPortraitUpsideDown = false;
            //Screen.autorotateToLandscapeLeft = true;
            //Screen.autorotateToLandscapeRight = true;
        }
    }
    public void SetVisible(GameObject Object)
    {
        Object.SetActive(!Object.activeSelf);

    }
    public void OpenLayoutPanel(bool open)
    {
        if (open)
        {
            components.MainPanel.SetActive(false);
            components.LayoutPanel.SetActive(true);
        }
        else
        {
            components.MainPanel.SetActive(true);
            components.LayoutPanel.SetActive(false);
        }
    }
    public void OpenGameScreen(bool open)
    {
        if (open)
        {
            components.MainPanel.SetActive(false);
            components.GameScreen.SetActive(true);
        }
        else
        {
            landscape = true;
            portrait = false;
            SetOrientation();
            components.MainPanel.SetActive(true);
            components.GameScreen.SetActive(false);
        }
    }
    public void OpenGameScreenPortrait(bool open)
    {
        if (open)
        {
            portrait = true;
            landscape = false;
            SetOrientation();
            components.MainPanel.SetActive(false);
            components.GameScreenPort.SetActive(true);
        }
        else
        {
            landscape = true;
            portrait = false;
            SetOrientation();
            components.MainPanel.SetActive(true);
            components.GameScreenPort.SetActive(false);
        }
    }
    public void changeScale()
    {

        sphere.transform.localScale = new Vector3(components.sliderx.value, components.slidery.value, components.sliderz.value);
    }
    public void sliderToggle()
    {
        if (components.slidertoggle.isOn)
        {
            components.renderview.gameObject.SetActive(true);
            components.colordropdown.interactable = true;
           // components.scrollreacttoggle.isOn = false;
        }
        else
        {
            components.renderview.gameObject.SetActive(false);
            components.colordropdown.interactable = false;
        }
    }
    public void scrollReactToggle()
    {

        if (components.scrollreacttoggle.isOn)
        {
           components.scrollrect.gameObject.SetActive(true);
            components.scrollrect2.gameObject.SetActive(true);
           // components.slidertoggle.isOn = false;
        }
        else
        {
            components.scrollrect.gameObject.SetActive(false);
            components.scrollrect2.gameObject.SetActive(false);
        }
    }
    public void showall()
    {
        if (components.showall.isOn)
        {
            components.slidertoggle.isOn = true;
            components.scrollreacttoggle.isOn = true;
        }
        else
        {
            components.slidertoggle.isOn = false;
            components.scrollreacttoggle.isOn = false;
        }
    }
    public void changecolor()
    {

        string option = components.colordropdown.options[components.colordropdown.value].text;
        Debug.Log(option);
        switch (option)
        {
            case "Red":
                spherematerial.color = Color.red;
                break;
            case "Green":
                spherematerial.color = Color.green;
                break;
            case "Blue":
                spherematerial.color = Color.blue;
                break;

        }
    }
    public void PopupAnimation(bool can)
    {
        if (can)
        {
            popup.SetBool("PopUp", true);
        }
        else
        {
            popup.SetBool("PopUp", false);
        }
    }
}
