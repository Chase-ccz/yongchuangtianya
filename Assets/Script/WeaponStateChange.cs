using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStateChange : MonoBehaviour
{
    public Transform circle;
    public Transform triangle;

    private Renderer circleRenderer;
    private Renderer triangleRenderer;
    public string weaponType;
    // Start is called before the first frame update
    void Start()
    {
        circleRenderer = circle.GetComponent<Renderer>();
        triangleRenderer = triangle.GetComponent<Renderer>();

        circleRenderer.enabled = false;
        triangleRenderer.enabled = true;
        weaponType = "range";
    }

    // Update is called once per frame
    void Update()
    {
        //Switcher();
    }

    public void Switcher()
    {
        //if (Input.GetButtonDown("Switch") || Input.touchCount == 2)
        //{
        circleRenderer.enabled = !circleRenderer.enabled;
        triangleRenderer.enabled = !triangleRenderer.enabled;
        //}
        if(circleRenderer.enabled == true)
        {
            weaponType = "melee";
        }
        else
        {
            weaponType = "range";
        }
        //Debug.Log(weaponType);
    }
}
