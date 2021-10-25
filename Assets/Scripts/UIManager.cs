using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIComponents components;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
    public void changeScale()
    {

        sphere.transform.localScale = new Vector3(components.sliderx.value, components.slidery.value, components.sliderz.value);
    }
    public void sliderToggle()
    {
        if (components.slidertoggle.isOn)
        {
            components.renderview.gameObject.SetActive(true);
            components.scrollreacttoggle.isOn = false;
        }
        else
        {
            components.renderview.gameObject.SetActive(false);
        }
    }
    public void scrollReactToggle()
    {

        if (components.scrollreacttoggle.isOn)
        {
           // components.renderview.gameObject.SetActive(true);
            components.slidertoggle.isOn = false;
        }
        else
        {
           
        }
    }
}
