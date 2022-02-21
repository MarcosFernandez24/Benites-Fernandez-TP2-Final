using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysScale : MonoBehaviour
{
    public GameObject[] Keys;

    public KeysScaleData KeysScaleData;

    void Start()
    {

         transform.localScale = KeysScaleData.Scale;

    }

    
}
