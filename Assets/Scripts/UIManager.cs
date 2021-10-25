using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIComponents components;
    public GameObject sphere;
    Material spherematerial;
    // Start is called before the first frame update
    void Start()
    {
        spherematerial = sphere.GetComponent<Renderer>().material;
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
            components.colordropdown.interactable = true;
            components.scrollreacttoggle.isOn = false;
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
            components.slidertoggle.isOn = false;
        }
        else
        {
            components.scrollrect.gameObject.SetActive(false);
        }
    }
    public void changecolor()
    {
        string option = components.colordropdown.itemText.text;
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
}
