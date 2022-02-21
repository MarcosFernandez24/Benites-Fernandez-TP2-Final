using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : InteractableObject
{
    private bauScript _bauScript;

    public override void OnInteraction()
    {
        base.OnInteraction();
        _bauScript.AbrirPublic(true);

    }

    private void Awake()
    {

        _bauScript = GetComponentInChildren<bauScript>();

    }

}
