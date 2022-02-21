using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float minimunDistance = 10;
   
    private void CameraPlayerFollow()
    {
        var VectorDistance = target.position - transform.position;

        var Direction = VectorDistance.normalized;

        if (VectorDistance.magnitude < minimunDistance)
        {

            transform.forward = Direction;

        }
    }

    private void Update()
    {
        CameraPlayerFollow();
    }


}
