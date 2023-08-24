using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOff : MonoBehaviour
{
    public GameObject objectToShowHide;

    void Start()
    {
        objectToShowHide.GetComponent<GameObject>();
    }

    public void Toggle()
    {
        if(objectToShowHide == true)
        {
            //objectToShowHide = active;
        }
        else
        {
            //objectToShowHide = false;
        }
    }
}
