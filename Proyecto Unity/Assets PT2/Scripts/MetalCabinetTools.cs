using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalCabinetTools : MonoBehaviour
{
    [SerializeField] private GameObject MetalCabinet;
    [SerializeField] private GameObject MetalCabinet2;

    public class DestroyCabinet : MetalCabinetTools
    {

        public void Start()
        {

            DCabinet1();
            Debug.Log($"Destroy Metal Cabinet 1");
        }

    }
    public class DestroyCabinet2 : MetalCabinetTools
    {

        public void Start()
        {

            DCabinet2();
            Debug.Log($"Destroy Metal Cabinet 2");
        }

    }
   
    public void DCabinet1()
    {

        Destroy(MetalCabinet);

    }
    public void DCabinet2()
    {

        Destroy(MetalCabinet2);

    }
}



