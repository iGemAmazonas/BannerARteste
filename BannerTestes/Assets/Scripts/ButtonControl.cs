using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject animChamander;

    public void clickStart()
    {
        animChamander.SetActive(true);        
    }

    public void clickStop()
    {
        animChamander.SetActive(false);
    }


}
