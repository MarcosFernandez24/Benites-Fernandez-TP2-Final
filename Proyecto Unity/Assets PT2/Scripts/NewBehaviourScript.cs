using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform Camera;
   

    // Start is called before the first frame update
    void Start()
    {
        Camera = transform.Find("Camera"); 
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(Camera.position, Camera.forward, Color.magenta);

    }
}
