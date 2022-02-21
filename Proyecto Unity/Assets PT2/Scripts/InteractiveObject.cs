using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    [SerializeField] private LayerMask PlayerLayer;
    [SerializeField] private Transform EyesTransform;
    [SerializeField] private float MaxDistance;
    
    public void RayCastInteraction()
    {
        RaycastHit hit;

      var RayCollided =  Physics.Raycast(EyesTransform.position, transform.forward, out hit, MaxDistance, PlayerLayer);
        if(RayCollided)
        {
            Debug.Log($"hit{hit.transform.position}");
        }
        else
        {
            Debug.Log("Not Hit");
        }


    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            RayCastInteraction();

        }
    }

}

