using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POWERBAR : MonoBehaviour
{
    public GameObject launcher;


    void Update()
    {
        this.GetComponent<UnityEngine.UI.Slider>().value = launcher.GetComponent<LauncherBehaviour>().power;
    }
}

