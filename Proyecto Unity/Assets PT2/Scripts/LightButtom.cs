using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtom : InteractableObject
{
    public List<Light> Lights;


    public override void OnInteraction()
    {
        base.OnInteraction();

        ToggleLights();
    }


    public enum LightMode
    {
        lightOn,
        lightOff,
        lightMedium

    };

    public LightMode LightSwitch;

    private void ToggleLights()
    {
        float lightIntensity = 0;

        switch (LightSwitch)
        {
            case LightMode.lightOn:

                lightIntensity = 1;

                LightSwitch = LightMode.lightOff;
                break;
            case LightMode.lightOff:

                

                LightSwitch = LightMode.lightMedium;
                break;
            case LightMode.lightMedium:

                lightIntensity = 0.5f;

                LightSwitch = LightMode.lightOn;
                break;

        }
        foreach (var item in Lights)
        {

            item.intensity = lightIntensity;

        }
    }

    }

   
        


