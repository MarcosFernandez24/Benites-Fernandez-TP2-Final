using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysInteraction : InteractableObject
{
    public GameObject Key;

    [SerializeField] private float MaxDistance;

    public override void OnInteraction()
    {
        base.OnInteraction();

        Destroy(Key);

        Debug.Log($"Key Collected");
    }


}
